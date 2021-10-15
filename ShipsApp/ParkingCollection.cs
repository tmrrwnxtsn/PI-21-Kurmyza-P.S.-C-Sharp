using System.Collections.Generic;
using System.Linq;

namespace ShipsApp
{
    public class ParkingCollection
    {
        private readonly Dictionary<string, Parking<Vehicle>> _parkingStages;

        public List<string> Keys => _parkingStages.Keys.ToList();

        private readonly int _pictureWidth;

        private readonly int _pictureHeight;

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            _parkingStages = new Dictionary<string, Parking<Vehicle>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (!_parkingStages.ContainsKey(name))
            {
                _parkingStages.Add(name, new Parking<Vehicle>(_pictureWidth, _pictureHeight));
            }
        }

        public void DelParking(string name)
        {
            if (_parkingStages.ContainsKey(name))
            {
                _parkingStages.Remove(name);
            }
        }


        public Parking<Vehicle> this[string name]
        {
            get
            {
                if (_parkingStages.ContainsKey(name))
                {
                    return _parkingStages[name];
                }
                return null;
            }
        }
    }
}
