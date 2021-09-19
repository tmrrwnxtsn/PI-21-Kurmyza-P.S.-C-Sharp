using System.Drawing;

namespace ShipsApp
{
    public class Ship : Vehicle
    {
        protected readonly int shipWidth = 250;

        protected readonly int shipHeight = 215;

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
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
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
                 new PointF(_startPosX + 25, _startPosY + 160),
                 new PointF(_startPosX + 25, _startPosY + 100),
                 new PointF(_startPosX + 15, _startPosY + 100),
                 new PointF(_startPosX + 15, _startPosY + 75),
                 new PointF(_startPosX + 70, _startPosY + 75),
                 new PointF(_startPosX + 70, _startPosY + 160),
                 new PointF(_startPosX + 25, _startPosY + 160)
             };
            g.FillPolygon(brushWhite, superstructureOutline);
            g.DrawLines(penMain, superstructureOutline);

            // Окна в надстройке 
            g.FillRectangle(brushMain, _startPosX + 60, _startPosY + 83, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 45, _startPosY + 83, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 30, _startPosY + 83, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 50, _startPosY + 103, 6, 6);
            g.FillRectangle(brushMain, _startPosX + 50, _startPosY + 118, 6, 6);
            g.FillRectangle(brushMain, _startPosX + 50, _startPosY + 133, 6, 6);

            // Нижняя часть трубы 
            PointF[] lowerPipeOutline =
             {
                 new PointF(_startPosX + 40, _startPosY + 73),
                 new PointF(_startPosX + 47, _startPosY + 65),
                 new PointF(_startPosX + 65, _startPosY + 65),
                 new PointF(_startPosX + 65, _startPosY + 73),
                 new PointF(_startPosX + 40, _startPosY + 73)
             };
            g.FillPolygon(brushOrange, lowerPipeOutline);

            // Верхняя часть трубы 
            PointF[] upperPipeOutline =
             {
                 new PointF(_startPosX + 47, _startPosY + 65),
                 new PointF(_startPosX + 53, _startPosY + 57),
                 new PointF(_startPosX + 65, _startPosY + 57),
                 new PointF(_startPosX + 65, _startPosY + 65)
             };
            g.FillPolygon(brushMain, upperPipeOutline);

            // Дно 
            PointF[] bottomOutline =
             {
                 new PointF(_startPosX + 220, _startPosY + 190),
                 new PointF(_startPosX + 230, _startPosY + 195),
                 new PointF(_startPosX + 230, _startPosY + 210),
                 new PointF(_startPosX + 30, _startPosY + 210),
                 new PointF(_startPosX + 20, _startPosY + 190),
                 new PointF(_startPosX + 220, _startPosY + 190)
             };
            g.FillPolygon(brushOrange, bottomOutline);

            // Корпус 
            PointF[] bodyOutline =
             {
                 new PointF(_startPosX + 220, _startPosY + 190),
                 new PointF(_startPosX + 20, _startPosY + 190),
                 new PointF(_startPosX + 10, _startPosY + 170),
                 new PointF(_startPosX + 10, _startPosY + 140),
                 new PointF(_startPosX + 40, _startPosY + 140),
                 new PointF(_startPosX + 50, _startPosY + 150),
                 new PointF(_startPosX + 240, _startPosY + 150),
                 new PointF(_startPosX + 220, _startPosY + 190)
             };
            g.FillPolygon(brushMain, bodyOutline);

            // Окна в корпусе
            g.FillRectangle(brushWhite, _startPosX + 210, _startPosY + 160, 8, 8);
            g.FillRectangle(brushWhite, _startPosX + 195, _startPosY + 160, 8, 8);

            penMain.Dispose();
            brushMain.Dispose();
            brushWhite.Dispose();
            brushOrange.Dispose();
        }
    }
}
