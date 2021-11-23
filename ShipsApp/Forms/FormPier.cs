using NLog;
using ShipsApp.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp
{
    public partial class FormPier : Form
    {
        private readonly PierCollection _pierCollection;

        private readonly Logger _logger;

        public FormPier()
        {
            InitializeComponent();

            _pierCollection = new PierCollection(pictureBoxPier.Width, pictureBoxPier.Height);

            _logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxPiers.SelectedIndex;

            listBoxPiers.Items.Clear();

            for (int i = 0; i < _pierCollection.Keys.Count; i++)
            {
                listBoxPiers.Items.Add(_pierCollection.Keys[i]);
            }

            if (listBoxPiers.Items.Count > 0 && (index == -1 || index >= listBoxPiers.Items.Count))
            {
                listBoxPiers.SelectedIndex = 0;
            }
            else if (listBoxPiers.Items.Count > 0 && index > -1 && index < listBoxPiers.Items.Count)
            {
                listBoxPiers.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxPiers.SelectedIndex > -1)
            {
                _pierCollection[listBoxPiers.SelectedItem.ToString()].Draw(gr);
            }
            else
            {
                gr.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, pictureBoxPier.Width, pictureBoxPier.Height);
            }
            pictureBoxPier.Image = bmp;
        }

        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(maskedTextBoxPlace.Text, out int index);
            if (success && listBoxPiers.SelectedIndex > -1)
            {
                try
                {
                    var ship = _pierCollection[listBoxPiers.SelectedItem.ToString()] - index;
                    if (ship != null)
                    {
                        FormShip form = new FormShip();
                        form.SetShip(ship);
                        form.ShowDialog();
                        Draw();

                        _logger.Info($"Судно «{ship}» изъято с места {maskedTextBoxPlace.Text}");
                    }
                }
                catch (ShipNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _logger.Warn($"Судно не найдено: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неудачная попытка изъятия судна", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _logger.Warn($"Не удалось изъять судно с пристани: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Некорректное значение места на пристани!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputPierName.Text))
            {
                MessageBox.Show("Введите название пристани!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pierCollection.AddPier(textBoxInputPierName.Text);
            ReloadLevels();

            _logger.Info($"Пристань «{textBoxInputPierName.Text}» добавлена");
        }

        private void buttonRemovePier_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить пристань «{listBoxPiers.SelectedItem}»?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _pierCollection.DelPier(listBoxPiers.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();

                    _logger.Info($"Пристань «{listBoxPiers.SelectedItem}» удалена");
                }
            }
        }

        private void listBoxShowPiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

            _logger.Info($"Выбрана пристань «{listBoxPiers.SelectedItem}»");
        }

        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            FormShipConfig formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(ParkShip);
            formShipConfig.Show();
        }

        private void ParkShip(ITransport ship)
        {
            if (listBoxPiers.SelectedIndex == -1)
            {
                MessageBox.Show("Некуда парковать судно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.Warn("Невозможно припарковать судно: ни одна пристань не создана");
                return;
            }
            else if (ship == null)
            {
                MessageBox.Show("Нечего парковать на пристань!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.Warn("Невозможно припарковать судно: оно не создано");
                return;
            }
            try
            {
                if ((_pierCollection[listBoxPiers.SelectedItem.ToString()]) + ship)
                {
                    Draw();

                    _logger.Info($"Добавлено судно «{ship}»");
                }
                else
                {
                    MessageBox.Show("Не удалось припарковать судно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (PierOverflowException ex)
            {
                MessageBox.Show(ex.Message, "Пристань переполнена", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _logger.Warn($"Невозможно добавить судно в переполненную пристань: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неудачная попытка припарковать судно", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _logger.Warn($"Неизвестная ошибка при попытке припарковать судно: {ex.Message}");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _pierCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно!", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _logger.Info($"Сохранено в файл «{saveFileDialog.FileName}»");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _logger.Warn($"Неизвестная ошибка при сохранении: {ex.Message}");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _pierCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show($"Информация из файла «{openFileDialog.FileName}» успешно загружена!", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ReloadLevels();
                    Draw();

                    _logger.Info($"Информация о пристанях загружена из файла «{openFileDialog.FileName}»");
                }
                catch (PierOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _logger.Warn($"Занятое место: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _logger.Warn($"Неизвестная ошибка при загрузке: {ex.Message}");
                }
            }
        }
    }
}
