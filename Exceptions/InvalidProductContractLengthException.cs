using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductContractLengthException : InvalidProductException
    {
        public InvalidProductContractLengthException()
        {
        }

        public InvalidProductContractLengthException(int length) 
            : base($"Contract Length [{length}] not allowed")
        {
        }
    }
}
