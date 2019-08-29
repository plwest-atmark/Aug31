using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToProgramming
{
    class CustomMadeException : Exception
    {
        public CustomMadeException()
        {
            // Do something special here
        }

        public CustomMadeException(string message) : base(message)
        {
            // Do something special here
        }
    }
}
