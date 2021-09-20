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
                g.DrawRectangle(penMain, StartPosX + 83, StartPosY + 118, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 83, StartPosY + 118, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 135, StartPosY + 118, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 135, StartPosY + 118, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 83, StartPosY + 86, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 83, StartPosY + 86, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 135, StartPosY + 86, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 135, StartPosY + 86, 50, 30);
            }

            if (Crane) // Кран
            {
                // Столб
                g.FillRectangle(brushAdditional, StartPosX + 200, StartPosY + 52, 15, 100);
                g.DrawRectangle(penMain, StartPosX + 200, StartPosY + 52, 15, 100);

                // Блок
                g.FillRectangle(brushAdditional, StartPosX + 192, StartPosY + 30, 30, 30);
                g.DrawRectangle(penMain, StartPosX + 192, StartPosY + 30, 30, 30);

                // Расширяемая опора для троса
                PointF[] upperPartOfCraneOutline =
                {
                    new PointF(StartPosX + 192, StartPosY + 35),
                    new PointF(StartPosX + 152, StartPosY + 25),
                    new PointF(StartPosX + 152, StartPosY + 35),
                    new PointF(StartPosX + 192, StartPosY + 50),
                    new PointF(StartPosX + 192, StartPosY + 35),
                };
                g.FillPolygon(brushAdditional, upperPartOfCraneOutline);
                g.DrawLines(penMain, upperPartOfCraneOutline);

                // Трос с крюком
                g.DrawLine(penMain, StartPosX + 162, StartPosY + 40, StartPosX + 162, StartPosY + 60);
                g.FillRectangle(brushAdditional, StartPosX + 157, StartPosY + 60, 10, 5);
                g.DrawRectangle(penMain, StartPosX + 157, StartPosY + 60, 10, 5);
                g.DrawLine(penMain, StartPosX + 157, StartPosY + 65, StartPosX + 147, StartPosY + 70);
                g.DrawLine(penMain, StartPosX + 145, StartPosY + 70, StartPosX + 157, StartPosY + 75);
                g.DrawLine(penMain, StartPosX + 167, StartPosY + 65, StartPosX + 177, StartPosY + 70);
                g.DrawLine(penMain, StartPosX + 179, StartPosY + 70, StartPosX + 167, StartPosY + 75);
            }

            penMain.Dispose();
            brushMain.Dispose();
            brushAdditional.Dispose();
            brushWhite.Dispose();
        }
    }
}
