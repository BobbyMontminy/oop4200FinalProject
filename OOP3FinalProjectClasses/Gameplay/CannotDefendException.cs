using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    class CannotDefendException : Exception
    {
        public CannotDefendException(string message)
            : base(message)
        {

        }

        public CannotDefendException()
            : base()
        {

        }
    }
}
