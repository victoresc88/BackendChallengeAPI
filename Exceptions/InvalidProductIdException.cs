using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductIdException : InvalidProductException
    {
        public InvalidProductIdException()
        {
        }

        public InvalidProductIdException(int id)
            : base($"Id [{id}] not allowed")
        {
        }
    }
}