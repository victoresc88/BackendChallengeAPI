using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductException : Exception
    {
        public InvalidProductException()
        {
        }

        public InvalidProductException(string message)
            : base($"Invalid Product: {message}")
        {   
        }
    }
}
