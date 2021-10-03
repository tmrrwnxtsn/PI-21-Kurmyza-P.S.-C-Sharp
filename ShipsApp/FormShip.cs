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

        public void SetShip(ITransport ship)
        {
            this.ship = ship;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship?.DrawTransport(gr);
            pictureBoxShip.Image = bmp;
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
