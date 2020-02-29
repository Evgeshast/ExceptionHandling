using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingModule
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        { }
    }
}
