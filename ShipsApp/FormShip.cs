using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp
{
    public partial class FormShip : Form
    {
        private ITransport ship;

        public FormShip()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawTransport(gr);
            pictureBoxShip.Image = bmp;
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonCreateContainerShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new ContainerShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Red, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string buttonName = (sender as Button).Name;
            switch (buttonName)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
