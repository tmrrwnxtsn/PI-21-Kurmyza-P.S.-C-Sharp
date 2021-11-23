using System;

namespace ShipsApp
{
    public class ShipNotFoundException : Exception
    {
        public ShipNotFoundException(int i) : base("Не найдено судно по месту " + i)
        {
        }
    }
}
