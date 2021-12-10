using System.Collections.Generic;

namespace ShipsApp
{
    public class ShipComparer : IComparer<ITransport>
    {
        public int Compare(ITransport x, ITransport y)
        {
            if (x is ContainerShip containerShipX && y is ContainerShip containerShipY)
            {
                return ComparerContainerShips(containerShipX, containerShipY);
            }
            if (x is ContainerShip && y is Ship)
            {
                return 1;
            }
            if (x is Ship && y is ContainerShip)
            {
                return -1;
            }
            if (x is Ship shipX && y is Ship shipY)
            {
                return CompareShips(shipX, shipY);
            }
            return 0;
        }

        private int CompareShips(Ship x, Ship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerContainerShips(ContainerShip x, ContainerShip y)
        {
            var res = CompareShips(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.AdditionalColor != y.AdditionalColor)
            {
                return x.AdditionalColor.Name.CompareTo(y.AdditionalColor.Name);
            }
            if (x.Crane != y.Crane)
            {
                return x.Crane.CompareTo(y.Crane);
            }
            if (x.Containers != y.Containers)
            {
                return x.Containers.CompareTo(y.Containers);
            }
            return 0;
        }
    }
}
