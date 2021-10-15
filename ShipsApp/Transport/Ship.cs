using System.Drawing;

namespace ShipsApp
{
    public class Ship : Vehicle
    {
        protected readonly int ShipWidth = 230;

        protected readonly int ShipHeight = 190;

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
                 new PointF(StartPosX + 5, StartPosY + 135),
                 new PointF(StartPosX + 5, StartPosY + 75),
                 new PointF(StartPosX - 5, StartPosY + 75),
                 new PointF(StartPosX - 5, StartPosY + 50),
                 new PointF(StartPosX + 50, StartPosY + 50),
                 new PointF(StartPosX + 50, StartPosY + 135),
                 new PointF(StartPosX + 5, StartPosY + 135)
             };
            g.FillPolygon(brushWhite, superstructureOutline);
            g.DrawLines(penMain, superstructureOutline);

            // Окна в надстройке 
            g.FillRectangle(brushMain, StartPosX + 40, StartPosY + 58, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 25, StartPosY + 58, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 10, StartPosY + 58, 10, 10);
            g.FillRectangle(brushMain, StartPosX + 30, StartPosY + 78, 6, 6);
            g.FillRectangle(brushMain, StartPosX + 30, StartPosY + 93, 6, 6);
            g.FillRectangle(brushMain, StartPosX + 30, StartPosY + 108, 6, 6);

            // Нижняя часть трубы 
            PointF[] lowerPipeOutline =
             {
                 new PointF(StartPosX + 20, StartPosY + 48),
                 new PointF(StartPosX + 27, StartPosY + 40),
                 new PointF(StartPosX + 45, StartPosY + 40),
                 new PointF(StartPosX + 45, StartPosY + 48),
                 new PointF(StartPosX + 20, StartPosY + 48)
             };
            g.FillPolygon(brushOrange, lowerPipeOutline);

            // Верхняя часть трубы 
            PointF[] upperPipeOutline =
             {
                 new PointF(StartPosX + 27, StartPosY + 40),
                 new PointF(StartPosX + 33, StartPosY + 33),
                 new PointF(StartPosX + 45, StartPosY + 33),
                 new PointF(StartPosX + 45, StartPosY + 40)
             };
            g.FillPolygon(brushMain, upperPipeOutline);

            // Дно 
            PointF[] bottomOutline =
             {
                 new PointF(StartPosX + 200, StartPosY + 165),
                 new PointF(StartPosX + 210, StartPosY + 170),
                 new PointF(StartPosX + 210, StartPosY + 185),
                 new PointF(StartPosX + 10, StartPosY + 185),
                 new PointF(StartPosX, StartPosY + 165),
                 new PointF(StartPosX + 200, StartPosY + 165)
             };
            g.FillPolygon(brushOrange, bottomOutline);

            // Корпус 
            PointF[] bodyOutline =
             {
                 new PointF(StartPosX + 200, StartPosY + 165),
                 new PointF(StartPosX, StartPosY + 165),
                 new PointF(StartPosX - 10, StartPosY + 145),
                 new PointF(StartPosX - 10, StartPosY + 115),
                 new PointF(StartPosX + 20, StartPosY + 115),
                 new PointF(StartPosX + 30, StartPosY + 125),
                 new PointF(StartPosX + 220, StartPosY + 125),
                 new PointF(StartPosX + 200, StartPosY + 165)
             };
            g.FillPolygon(brushMain, bodyOutline);

            // Окна в корпусе
            g.FillRectangle(brushWhite, StartPosX + 190, StartPosY + 135, 8, 8);
            g.FillRectangle(brushWhite, StartPosX + 175, StartPosY + 135, 8, 8);

            penMain.Dispose();
            brushMain.Dispose();
            brushWhite.Dispose();
            brushOrange.Dispose();
        }
    }
}
