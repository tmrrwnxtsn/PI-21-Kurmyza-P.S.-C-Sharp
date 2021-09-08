using System.Drawing;

namespace ContainerShipApp
{
    public class ContainerShip
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private readonly int containerShipWidth = 240;

        private readonly int containerShipHeight = 195;

        public int MaxSpeed { get; private set; }

        public float Weight { get; private set; }

        public Color MainColor { get; private set; }

        public Color AdditionalColor { get; private set; }

        public bool Containers { get; private set; }

        public bool Crane { get; private set; }

        public ContainerShip(int maxSpeed, float weight, Color mainColor, Color additionalColor, bool containers, bool crane)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            AdditionalColor = additionalColor;
            Containers = containers;
            Crane = crane;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + 55 + step < _pictureWidth - containerShipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX + 55 - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY + 70 - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + 70 + step < _pictureHeight - containerShipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen penMain = new Pen(MainColor, 4);
            Brush brushWhite = new SolidBrush(Color.White);
            Brush brushOrange = new SolidBrush(Color.Orange);
            Brush brushMain = new SolidBrush(MainColor);
            Brush brushAdditional = new SolidBrush(AdditionalColor);

            // Надстройка 
            PointF[] superstructureOutline =
             {
                 new PointF(_startPosX + 75, _startPosY + 210),
                 new PointF(_startPosX + 75, _startPosY + 150),
                 new PointF(_startPosX + 65, _startPosY + 150),
                 new PointF(_startPosX + 65, _startPosY + 125),
                 new PointF(_startPosX + 120, _startPosY + 125),
                 new PointF(_startPosX + 120, _startPosY + 210),
                 new PointF(_startPosX + 75, _startPosY + 210)
             };
            g.FillPolygon(brushWhite, superstructureOutline);
            g.DrawLines(penMain, superstructureOutline);

            // Окна в надстройке 
            g.FillRectangle(brushMain, _startPosX + 110, _startPosY + 133, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 95, _startPosY + 133, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 80, _startPosY + 133, 10, 10);
            g.FillRectangle(brushMain, _startPosX + 100, _startPosY + 153, 6, 6);
            g.FillRectangle(brushMain, _startPosX + 100, _startPosY + 168, 6, 6);
            g.FillRectangle(brushMain, _startPosX + 100, _startPosY + 183, 6, 6);

            // Нижняя часть трубы 
            PointF[] lowerPipeOutline =
             {
                 new PointF(_startPosX + 90, _startPosY + 123),
                 new PointF(_startPosX + 97, _startPosY + 115),
                 new PointF(_startPosX + 115, _startPosY + 115),
                 new PointF(_startPosX + 115, _startPosY + 123),
                 new PointF(_startPosX + 90, _startPosY + 123)
             };
            g.FillPolygon(brushOrange, lowerPipeOutline);

            // Верхняя часть трубы 
            PointF[] upperPipeOutline =
             {
                 new PointF(_startPosX + 97, _startPosY + 115),
                 new PointF(_startPosX + 103, _startPosY + 107),
                 new PointF(_startPosX + 115, _startPosY + 107),
                 new PointF(_startPosX + 115, _startPosY + 115)
             };
            g.FillPolygon(brushMain, upperPipeOutline);

            // Дно 
            PointF[] bottomOutline =
             {
                 new PointF(_startPosX + 270, _startPosY + 240),
                 new PointF(_startPosX + 280, _startPosY + 245),
                 new PointF(_startPosX + 280, _startPosY + 260),
                 new PointF(_startPosX + 80, _startPosY + 260),
                 new PointF(_startPosX + 70, _startPosY + 240),
                 new PointF(_startPosX + 270, _startPosY + 240)
             };
            g.FillPolygon(brushOrange, bottomOutline);

            // Корпус 
            PointF[] bodyOutline =
             {
                 new PointF(_startPosX + 270, _startPosY + 240),
                 new PointF(_startPosX + 70, _startPosY + 240),
                 new PointF(_startPosX + 60, _startPosY + 220),
                 new PointF(_startPosX + 60, _startPosY + 190),
                 new PointF(_startPosX + 90, _startPosY + 190),
                 new PointF(_startPosX + 100, _startPosY + 200),
                 new PointF(_startPosX + 290, _startPosY + 200),
                 new PointF(_startPosX + 270, _startPosY + 240)
             };
            g.FillPolygon(brushMain, bodyOutline);

            // Окна в корпусе
            g.FillRectangle(brushWhite, _startPosX + 260, _startPosY + 210, 8, 8);
            g.FillRectangle(brushWhite, _startPosX + 245, _startPosY + 210, 8, 8);

            if (Containers) // Контейнеры
            {
                g.DrawRectangle(penMain, _startPosX + 133, _startPosY + 168, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 133, _startPosY + 168, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 185, _startPosY + 168, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 185, _startPosY + 168, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 133, _startPosY + 136, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 133, _startPosY + 136, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 185, _startPosY + 136, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 185, _startPosY + 136, 50, 30);
            }

            if (Crane) // Кран
            {
                // Столб
                g.FillRectangle(brushAdditional, _startPosX + 250, _startPosY + 102, 15, 100);
                g.DrawRectangle(penMain, _startPosX + 250, _startPosY + 102, 15, 100);

                // Блок
                g.FillRectangle(brushAdditional, _startPosX + 242, _startPosY + 80, 30, 30);
                g.DrawRectangle(penMain, _startPosX + 242, _startPosY + 80, 30, 30);

                // Расширяемая опора для троса
                PointF[] upperPartOfCraneOutline =
                {
                    new PointF(_startPosX + 242, _startPosY + 85),
                    new PointF(_startPosX + 202, _startPosY + 75),
                    new PointF(_startPosX + 202, _startPosY + 85),
                    new PointF(_startPosX + 242, _startPosY + 100),
                    new PointF(_startPosX + 242, _startPosY + 85),
                };
                g.FillPolygon(brushAdditional, upperPartOfCraneOutline);
                g.DrawLines(penMain, upperPartOfCraneOutline);

                // Трос с крюком
                g.DrawLine(penMain, _startPosX + 212, _startPosY + 90, _startPosX + 212, _startPosY + 110);
                g.FillRectangle(brushAdditional, _startPosX + 207, _startPosY + 110, 10, 5);
                g.DrawRectangle(penMain, _startPosX + 207, _startPosY + 110, 10, 5);
                g.DrawLine(penMain, _startPosX + 207, _startPosY + 115, _startPosX + 197, _startPosY + 120);
                g.DrawLine(penMain, _startPosX + 195, _startPosY + 120, _startPosX + 207, _startPosY + 125);
                g.DrawLine(penMain, _startPosX + 217, _startPosY + 115, _startPosX + 227, _startPosY + 120);
                g.DrawLine(penMain, _startPosX + 229, _startPosY + 120, _startPosX + 217, _startPosY + 125);
            };

            penMain.Dispose();
            brushMain.Dispose();
            brushAdditional.Dispose();
            brushWhite.Dispose();
        }
    }
}
