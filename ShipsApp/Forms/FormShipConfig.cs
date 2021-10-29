using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipsApp.Forms
{
    public partial class FormShipConfig : Form
    {
        private ITransport ship = null;

        private event Action<ITransport> eventParkShip;

        public FormShipConfig()
        {
            InitializeComponent();

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShowShip.Width, pictureBoxShowShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(12, 30, pictureBoxShowShip.Width, pictureBoxShowShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShowShip.Image = bmp;
            }
        }

        public void AddEvent(Action<ITransport> ev)
        {
            if (eventParkShip == null)
            {
                eventParkShip = ev;
            }
            else
            {
                eventParkShip += ev;
            }
        }

        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelContainerShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelContainerShip.DoDragDrop(labelContainerShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShowShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelShowShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычное судно":
                    ship = new Ship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black);
                    break;
                case "Контейнеровоз":
                    ship = new ContainerShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black, Color.Red, checkBoxContainers.Checked, checkBoxCrane.Checked);
                    break;
            }
            DrawShip();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Color)) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelAdditionalColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is ContainerShip)
                {
                    (ship as ContainerShip).SetAdditionalColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }

        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            eventParkShip?.Invoke(ship);
            Close();
        }
    }
}
