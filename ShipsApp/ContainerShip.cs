using System.Drawing;

namespace ShipsApp
{
    public class ContainerShip : Ship
    {
        public Color AdditionalColor { get; private set; }

        public bool Containers { get; private set; }

        public bool Crane { get; private set; }

        public ContainerShip(int maxSpeed, float weight, Color mainColor, Color additionalColor, bool containers, bool crane) : base(maxSpeed, weight, mainColor, 250, 215)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            AdditionalColor = additionalColor;
            Containers = containers;
            Crane = crane;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);

            Pen penMain = new Pen(MainColor, 4);
            Brush brushWhite = new SolidBrush(Color.White);
            Brush brushMain = new SolidBrush(MainColor);
            Brush brushAdditional = new SolidBrush(AdditionalColor);

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
