using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class InvalidUserCustomException:Exception
    {
        public InvalidUserCustomException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
