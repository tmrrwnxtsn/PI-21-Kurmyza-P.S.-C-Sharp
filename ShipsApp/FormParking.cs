using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp
{
    public partial class FormParking : Form
    {
        private readonly Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (parking + ship != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена!");
                }
            }
        }

        private void buttonParkContainerShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogAdditional = new ColorDialog();
                if (dialogAdditional.ShowDialog() == DialogResult.OK)
                {
                    var ship = new ContainerShip(100, 1000, dialog.Color, dialogAdditional.Color, true, true);
                    if (parking + ship != -1)
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

        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(maskedTextBoxPlace.Text, out int index);
            if (success)
            {
                var ship = parking - index;
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
    }
}
