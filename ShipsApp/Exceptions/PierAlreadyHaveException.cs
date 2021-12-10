using System;

namespace ShipsApp
{
    public class PierAlreadyHaveException : Exception
    {
        public PierAlreadyHaveException() : base("На пристани уже есть такое судно!")
        {
        }
    }
}
