﻿using System;
using System.Drawing;

namespace ShipsApp
{
    public class ContainerShip : Ship, IEquatable<ContainerShip>
    {
        public Color AdditionalColor { get; private set; }

        public bool Containers { get; private set; }

        public bool Crane { get; private set; }

        public ContainerShip(int maxSpeed, float weight, Color mainColor, Color additionalColor, bool containers, bool crane) : base(maxSpeed, weight, mainColor, 230, 190)
        {
            AdditionalColor = additionalColor;
            Containers = containers;
            Crane = crane;
        }

        public ContainerShip(string info): base(info)
        {
            string[] strs = info.Split(Separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                AdditionalColor = Color.FromName(strs[3]);
                Containers = Convert.ToBoolean(strs[4]);
                Crane = Convert.ToBoolean(strs[5]);
            }
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
                g.DrawRectangle(penMain, StartPosX + 63, StartPosY + 93, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 63, StartPosY + 93, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 115, StartPosY + 93, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 115, StartPosY + 93, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 63, StartPosY + 61, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 63, StartPosY + 61, 50, 30);
                g.DrawRectangle(penMain, StartPosX + 115, StartPosY + 61, 50, 30);
                g.FillRectangle(brushAdditional, StartPosX + 115, StartPosY + 61, 50, 30);
            }

            if (Crane) // Кран
            {
                // Столб
                g.FillRectangle(brushAdditional, StartPosX + 180, StartPosY + 23, 15, 100);
                g.DrawRectangle(penMain, StartPosX + 180, StartPosY + 23, 15, 100);

                // Блок
                g.FillRectangle(brushAdditional, StartPosX + 172, StartPosY + 5, 30, 30);
                g.DrawRectangle(penMain, StartPosX + 172, StartPosY + 5, 30, 30);

                // Расширяемая опора для троса
                PointF[] upperPartOfCraneOutline =
                {
                    new PointF(StartPosX + 172, StartPosY + 10),
                    new PointF(StartPosX + 132, StartPosY),
                    new PointF(StartPosX + 132, StartPosY + 10),
                    new PointF(StartPosX + 172, StartPosY + 25),
                    new PointF(StartPosX + 172, StartPosY + 10),
                };
                g.FillPolygon(brushAdditional, upperPartOfCraneOutline);
                g.DrawLines(penMain, upperPartOfCraneOutline);

                // Трос с крюком
                g.DrawLine(penMain, StartPosX + 142, StartPosY + 15, StartPosX + 142, StartPosY + 35);
                g.FillRectangle(brushAdditional, StartPosX + 137, StartPosY + 35, 10, 5);
                g.DrawRectangle(penMain, StartPosX + 137, StartPosY + 35, 10, 5);
                g.DrawLine(penMain, StartPosX + 137, StartPosY + 40, StartPosX + 127, StartPosY + 45);
                g.DrawLine(penMain, StartPosX + 125, StartPosY + 45, StartPosX + 137, StartPosY + 50);
                g.DrawLine(penMain, StartPosX + 147, StartPosY + 40, StartPosX + 157, StartPosY + 45);
                g.DrawLine(penMain, StartPosX + 159, StartPosY + 45, StartPosX + 147, StartPosY + 50);
            }

            penMain.Dispose();
            brushMain.Dispose();
            brushAdditional.Dispose();
            brushWhite.Dispose();
        }

        public void SetAdditionalColor(Color color)
        {
            AdditionalColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Separator}{AdditionalColor.Name}{Separator}{Containers}{Separator}{Crane}";
        }

        public bool Equals(ContainerShip other)
        {
            if (!base.Equals(other))
            {
                return false;
            }
            if (Crane != other.Crane)
            {
                return false;
            }
            if (Containers != other.Containers)
            {
                return false;
            }
            if (AdditionalColor != other.AdditionalColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ContainerShip shipObj))
            {
                return false;
            } 
            else
            {
                return Equals(shipObj);
            }
        }
    }
}
