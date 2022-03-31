using System;

namespace ShipsApp
{
    public class PierNotFoundException : Exception
    {
        public PierNotFoundException(int i) : base("Не найдено судно по месту " + i)
        {
        }
    }
}
