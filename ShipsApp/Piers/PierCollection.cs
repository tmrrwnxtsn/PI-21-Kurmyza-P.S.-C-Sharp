using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShipsApp
{
    public class PierCollection
    {
        private readonly Dictionary<string, Pier<ITransport>> _pierStages;

        public List<string> Keys => _pierStages.Keys.ToList();

        private readonly int _pictureWidth;

        private readonly int _pictureHeight;

        private readonly char _separator = ':';

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

        public void SaveData(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                sw.WriteLine("PierCollection");
                foreach (var level in _pierStages)
                {
                    sw.WriteLine($"Pier{_separator}{level.Key}");

                    ITransport ship;
                    for (int i = 0; (ship = level.Value.GetShip(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.Write($"Ship{_separator}");
                            }
                            if (ship.GetType().Name == "ContainerShip")
                            {
                                sw.Write($"ContainerShip{_separator}");
                            }
                            sw.WriteLine(ship);
                        }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("PierCollection"))
                {
                    _pierStages.Clear();
                }
                else
                {
                    throw new FileFormatException("Некорректный формат файла");
                }

                ITransport ship = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    if (line.Contains("Pier"))
                    {
                        key = line.Split(_separator)[1];
                        _pierStages.Add(key, new Pier<ITransport>(_pictureWidth, _pictureHeight));
                        continue;
                    }

                    if (line.Split(_separator)[0] == "Ship")
                    {
                        ship = new Ship(line.Split(_separator)[1]);
                    }
                    else if (line.Split(_separator)[0] == "ContainerShip")
                    {
                        ship = new ContainerShip(line.Split(_separator)[1]);
                    }

                    var result = _pierStages[key] + ship;
                    if (!result)
                    {
                        throw new TypeLoadException("Не удалось загрузить судно на пристань");
                    }
                }
            }
        }
    }
}
