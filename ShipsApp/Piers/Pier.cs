using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace ShipsApp
{
    public class Pier<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int _pictureWidth;

        private readonly int _pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 190;

        private int _currIdx;

        public T Current => _places[_currIdx];

        object IEnumerator.Current => _places[_currIdx];

        public Pier(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _places = new List<T>();
            _currIdx = -1;
        }

        public static bool operator +(Pier<T> p, T ship)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new PierOverflowException();
            }
            if (p._places.Contains(ship))
            {
                throw new PierAlreadyHaveException();
            }

            p._places.Add(ship);
            return true;
        }

        public static T operator -(Pier<T> p, int index)
        {
            if (index < 0 || index >= p._maxCount)
            {
                throw new PierNotFoundException(index);
            }

            T ship = p._places[index];
            p._places.RemoveAt(index);
            return ship;
        }
        
        public void Draw(Graphics g)
        {
            DrawMarking(g);

            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(15 + i % 4 * _placeSizeWidth, i / 4 * _placeSizeHeight, _pictureWidth, _pictureHeight);
                _places[i].DrawTransport(g);
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

        public T GetShip(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort() => _places.Sort(new ShipComparer());

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _currIdx++;
            return (_currIdx < _places.Count);
        }

        public void Reset()
        {
            _currIdx = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
