using System.Drawing;

namespace ShipsApp
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;

        private readonly int _pictureWidth;

        private readonly int _pictureHeight;

        private readonly int _placeSizeWidth = 210;

        private readonly int _placeSizeHeight = 80;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
        }


        public static int operator +(Parking<T> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.IsPlaceFree(i))
                {
                    p._places[i] = car;
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
                    i % 5 * p._placeSizeHeight + 15, p._pictureWidth, p._pictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.IsPlaceFree(index))
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }

        private bool IsPlaceFree(int index)
        {
            return _places[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
