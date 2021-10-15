using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection _parkingCollection;

        public FormParking()
        {
            InitializeComponent();
            _parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;

            listBoxParkings.Items.Clear();

            for (int i = 0; i < _parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(_parkingCollection.Keys[i]);
            }

            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxParkings.SelectedIndex > -1)
            {
                _parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
            }
            else
            {
                gr.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, pictureBoxParking.Width, pictureBoxParking.Height);
            }
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(100, 1000, dialog.Color);
                    if (_parkingCollection[listBoxParkings.SelectedItem.ToString()] + ship)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена!");
                    }
                }
            }
        }

        private void buttonParkContainerShip_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogAdditional = new ColorDialog();
                    if (dialogAdditional.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new ContainerShip(100, 1000, dialog.Color, dialogAdditional.Color, true, true);
                        if (_parkingCollection[listBoxParkings.SelectedItem.ToString()] + ship)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена!");
                        }
                    }
                }
            }
        }

        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(maskedTextBoxPlace.Text, out int index);
            if (success && listBoxParkings.SelectedIndex > -1)
            {
                var ship = _parkingCollection[listBoxParkings.SelectedItem.ToString()] - index;
                if (ship != null)
                {
                    FormShip form = new FormShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Некорректное значение парковочного места!");
                }
                Draw();
            }
            else
            {
                MessageBox.Show("Некорректное значение парковочного места!");
            }
        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputParkingName.Text))
            {
                MessageBox.Show("Введите название парковки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _parkingCollection.AddParking(textBoxInputParkingName.Text);
            ReloadLevels();
        }

        private void buttonRemoveParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку «{listBoxParkings.SelectedItem}»?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
            Draw();
        }

        private void listBoxShowParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
