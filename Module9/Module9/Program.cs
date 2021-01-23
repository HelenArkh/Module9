using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Собственное исключения");
            exception.HelpLink = "www.google.ru";
        }

        
    }
}
