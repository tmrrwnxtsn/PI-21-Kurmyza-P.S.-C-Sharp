using System.Drawing;

namespace ShipsApp
{
    public abstract class Vehicle : ITransport
    {
        protected float StartPosX;

        protected float StartPosY;

        protected int PictureWidth;

        protected int PictureHeight;

        public int MaxSpeed { get; protected set; }

        public float Weight { get; protected set; }

        public Color MainColor { get; protected set; }

        public void SetPosition(int x, int y, int width, int height)
        {
            StartPosX = x;
            StartPosY = y;
            PictureWidth = width;
            PictureHeight = height;
        }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public abstract void DrawTransport(Graphics g);
        
        public abstract void MoveTransport(Direction direction);
    }
}
