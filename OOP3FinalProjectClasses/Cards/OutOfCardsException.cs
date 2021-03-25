using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    class OutOfCardsException : Exception
    {
        public OutOfCardsException(String message)
            : base(message)
        { }

        public OutOfCardsException()
            :base()
        {

        }
    }
}
