using System.Drawing;

namespace ShipsApp
{
    public class Ship : Vehicle
    {
        protected readonly int ShipWidth = 250;

        protected readonly int ShipHeight = 215;

        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Ship(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            ShipWidth = shipWidth;
            ShipHeight = shipHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (StartPosX + step < PictureWidth - ShipWidth)
                    {
                        StartPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (StartPosX - step > 0)
                    {
                        StartPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (StartPosY - step > 0)
                    {
                        StartPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (StartPosY + step < PictureHeight - ShipHeight)
                    {
                        StartPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen penMain = new Pen(MainColor, 4);
            Brush brushWhite = new SolidBrush(Color.White);
            Brush brushOrange = new SolidBrush(Color.Orange);
            Brush brushMain = new SolidBrush(MainColor);

            // Надстройка 
            PointF[] superstructureOutline =
             {
                 new PointF(StartPosX + 25, StartPosY + 160),
                 new PointF(StartPosX + 25, StartPosY + 100),
                 new PointF(StartPosX + 15, StartPosY + 100),
                 new PointF(StartPosX + 15, StartPosY + 75),
                 new PointF(StartPosX + 70, StartPosY + 75),
                 new PointF(StartPosX + 70, StartPosY + 160),
                 new PointF(StartPosX + 25, StartPosY + 160)
             };
            g.FillPolygon(brushWhite, superstructureOutline);
            g.DrawLines(penMain, superstructureOutline);

            // Окна в надстройке 
            g.FillRectangle(brushMain, StartPosX + 60, StartPosY + 83, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 45, StartPosY + 83, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 30, StartPosY + 83, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 50, StartPosY + 103, 6, 6);
            g.FillRectangle(brushMain, StartPosX + 50, StartPosY + 118, 6, 6);
            g.FillRectangle(brushMain, StartPosX + 50, StartPosY + 133, 6, 6);

            // Нижняя часть трубы 
            PointF[] lowerPipeOutline =
             {
                 new PointF(StartPosX + 40, StartPosY + 73),
                 new PointF(StartPosX + 47, StartPosY + 65),
                 new PointF(StartPosX + 65, StartPosY + 65),
                 new PointF(StartPosX + 65, StartPosY + 73),
                 new PointF(StartPosX + 40, StartPosY + 73)
             };
            g.FillPolygon(brushOrange, lowerPipeOutline);

            // Верхняя часть трубы 
            PointF[] upperPipeOutline =
             {
                 new PointF(StartPosX + 47, StartPosY + 65),
                 new PointF(StartPosX + 53, StartPosY + 57),
                 new PointF(StartPosX + 65, StartPosY + 57),
                 new PointF(StartPosX + 65, StartPosY + 65)
             };
            g.FillPolygon(brushMain, upperPipeOutline);

            // Дно 
            PointF[] bottomOutline =
             {
                 new PointF(StartPosX + 220, StartPosY + 190),
                 new PointF(StartPosX + 230, StartPosY + 195),
                 new PointF(StartPosX + 230, StartPosY + 210),
                 new PointF(StartPosX + 30, StartPosY + 210),
                 new PointF(StartPosX + 20, StartPosY + 190),
                 new PointF(StartPosX + 220, StartPosY + 190)
             };
            g.FillPolygon(brushOrange, bottomOutline);

            // Корпус 
            PointF[] bodyOutline =
             {
                 new PointF(StartPosX + 220, StartPosY + 190),
                 new PointF(StartPosX + 20, StartPosY + 190),
                 new PointF(StartPosX + 10, StartPosY + 170),
                 new PointF(StartPosX + 10, StartPosY + 140),
                 new PointF(StartPosX + 40, StartPosY + 140),
                 new PointF(StartPosX + 50, StartPosY + 150),
                 new PointF(StartPosX + 240, StartPosY + 150),
                 new PointF(StartPosX + 220, StartPosY + 190)
             };
            g.FillPolygon(brushMain, bodyOutline);

            // Окна в корпусе
            g.FillRectangle(brushWhite, StartPosX + 210, StartPosY + 160, 8, 8);
            g.FillRectangle(brushWhite, StartPosX + 195, StartPosY + 160, 8, 8);

            penMain.Dispose();
            brushMain.Dispose();
            brushWhite.Dispose();
            brushOrange.Dispose();
        }
    }
}
