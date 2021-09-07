using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContainerShipApp
{
    public partial class FormContainerShip : Form
    {
        private ContainerShip _containerShip;

        public FormContainerShip()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxContainerShip.Width, pictureBoxContainerShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _containerShip.DrawTransport(gr);
            pictureBoxContainerShip.Image = bmp;
        }

        private void buttonCreateContainerShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _containerShip = new ContainerShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Red, true, true);
            _containerShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxContainerShip.Width, pictureBoxContainerShip.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string buttonName = (sender as Button).Name;
            switch (buttonName)
            {
                case "buttonUp":
                    _containerShip.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _containerShip.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _containerShip.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _containerShip.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
