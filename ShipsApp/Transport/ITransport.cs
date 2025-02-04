﻿using System.Drawing;

namespace ShipsApp
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);

        void SetMainColor(Color color);
    }
}
