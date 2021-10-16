using System.Collections.Generic;
using System.Linq;

namespace ShipsApp
{
    public class PierCollection
    {
        private readonly Dictionary<string, Pier<ITransport>> _pierStages;

        public List<string> Keys => _pierStages.Keys.ToList();

        private readonly int _pictureWidth;

        private readonly int _pictureHeight;

        public PierCollection(int pictureWidth, int pictureHeight)
        {
            _pierStages = new Dictionary<string, Pier<ITransport>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        public void AddPier(string name)
        {
            if (!_pierStages.ContainsKey(name))
            {
                _pierStages.Add(name, new Pier<ITransport>(_pictureWidth, _pictureHeight));
            }
        }

        public void DelPier(string name)
        {
            if (_pierStages.ContainsKey(name))
            {
                _pierStages.Remove(name);
            }
        }

        public Pier<ITransport> this[string name]
        {
            get
            {
                if (_pierStages.ContainsKey(name))
                {
                    return _pierStages[name];
                }
                return null;
            }
        }
    }
}
