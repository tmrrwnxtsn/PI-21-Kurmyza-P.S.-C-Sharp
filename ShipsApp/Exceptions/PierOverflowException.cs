using System;

namespace ShipsApp
{
    public class PierOverflowException : Exception
    {
        public PierOverflowException() : base("На пристани нет свободных мест")
        {
        }
    }
}
