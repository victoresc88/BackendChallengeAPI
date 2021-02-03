using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductContractLengthException : Exception
    {
        public InvalidProductContractLengthException()
        {
        }

        public InvalidProductContractLengthException(int length) 
            : base($"Invalid Contract Length: {length}")
        {
        }
    }
}
