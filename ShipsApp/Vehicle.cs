using System.Drawing;

namespace ShipsApp
{
    public abstract class Vehicle : ITransport
    {
        protected float _startPosX;

        protected float _startPosY;

        protected int _pictureWidth;

        protected int _pictureHeight;

        public int MaxSpeed { get; protected set; }

        public float Weight { get; protected set; }

        public Color MainColor { get; protected set; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawTransport(Graphics g);
        
        public abstract void MoveTransport(Direction direction);
    }
}
