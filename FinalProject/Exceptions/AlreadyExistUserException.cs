using System;

namespace FinalProject
{
    // Класс исключения для ситуации, когда пользователь с данным логином уже существует
    public class AlreadyExistUserException : Exception
    {
        public AlreadyExistUserException(string message) : base(message)
        {
        }
    }
}
