using System.Drawing;

namespace ContainerShipApp
{
    public class ContainerShip
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private readonly int containerShipWidth = 250;

        private readonly int containerShipHeight = 215;

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
                    if (_startPosX + step < _pictureWidth - containerShipWidth)
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
                    if (_startPosY + step < _pictureHeight - containerShipHeight)
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

            if (Containers) // Контейнеры
            {
                g.DrawRectangle(penMain, _startPosX + 83, _startPosY + 118, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 83, _startPosY + 118, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 135, _startPosY + 118, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 135, _startPosY + 118, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 83, _startPosY + 86, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 83, _startPosY + 86, 50, 30);
                g.DrawRectangle(penMain, _startPosX + 135, _startPosY + 86, 50, 30);
                g.FillRectangle(brushAdditional, _startPosX + 135, _startPosY + 86, 50, 30);
            }

            if (Crane) // Кран
            {
                // Столб
                g.FillRectangle(brushAdditional, _startPosX + 200, _startPosY + 52, 15, 100);
                g.DrawRectangle(penMain, _startPosX + 200, _startPosY + 52, 15, 100);

                // Блок
                g.FillRectangle(brushAdditional, _startPosX + 192, _startPosY + 30, 30, 30);
                g.DrawRectangle(penMain, _startPosX + 192, _startPosY + 30, 30, 30);

                // Расширяемая опора для троса
                PointF[] upperPartOfCraneOutline =
                {
                    new PointF(_startPosX + 192, _startPosY + 35),
                    new PointF(_startPosX + 152, _startPosY + 25),
                    new PointF(_startPosX + 152, _startPosY + 35),
                    new PointF(_startPosX + 192, _startPosY + 50),
                    new PointF(_startPosX + 192, _startPosY + 35),
                };
                g.FillPolygon(brushAdditional, upperPartOfCraneOutline);
                g.DrawLines(penMain, upperPartOfCraneOutline);

                // Трос с крюком
                g.DrawLine(penMain, _startPosX + 162, _startPosY + 40, _startPosX + 162, _startPosY + 60);
                g.FillRectangle(brushAdditional, _startPosX + 157, _startPosY + 60, 10, 5);
                g.DrawRectangle(penMain, _startPosX + 157, _startPosY + 60, 10, 5);
                g.DrawLine(penMain, _startPosX + 157, _startPosY + 65, _startPosX + 147, _startPosY + 70);
                g.DrawLine(penMain, _startPosX + 145, _startPosY + 70, _startPosX + 157, _startPosY + 75);
                g.DrawLine(penMain, _startPosX + 167, _startPosY + 65, _startPosX + 177, _startPosY + 70);
                g.DrawLine(penMain, _startPosX + 179, _startPosY + 70, _startPosX + 167, _startPosY + 75);
            };

            penMain.Dispose();
            brushMain.Dispose();
            brushAdditional.Dispose();
            brushWhite.Dispose();
        }
    }
}
