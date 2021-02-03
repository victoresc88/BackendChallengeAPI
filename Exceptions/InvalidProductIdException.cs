using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductIdException : Exception
    {
        public InvalidProductIdException()
        {
        }

        public InvalidProductIdException(int id)
            : base($"Invalid Id: {id}")
        {
        }
    }
}