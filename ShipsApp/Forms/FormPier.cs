using ShipsApp.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp
{
    public partial class FormPier : Form
    {
        private readonly PierCollection _pierCollection;

        public FormPier()
        {
            InitializeComponent();

            _pierCollection = new PierCollection(pictureBoxPier.Width, pictureBoxPier.Height);
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
                var ship = _pierCollection[listBoxPiers.SelectedItem.ToString()] - index;
                if (ship != null)
                {
                    FormShip form = new FormShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Некорректное значение места на пристани!");
                }
                Draw();
            }
            else
            {
                MessageBox.Show("Некорректное значение места на пристани!");
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
        }

        private void buttonRemovePier_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить пристань «{listBoxPiers.SelectedItem}»?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _pierCollection.DelPier(listBoxPiers.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
            Draw();
        }

        private void listBoxShowPiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            FormShipConfig formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(ParkShip);
            formShipConfig.Show();
        }

        private void ParkShip(ITransport ship)
        {
            if (ship != null && listBoxPiers.SelectedIndex > -1)
            {
                if ((_pierCollection[listBoxPiers.SelectedItem.ToString()]) + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Пристань переполнена!");
                }
            }
            else
            {
                MessageBox.Show("Некуда парковать судно!");
            }
        }
    }
}
