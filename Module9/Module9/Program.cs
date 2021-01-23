using System;

namespace Module9
{
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Сообщение об ошибке");
            }
            catch (Exception ex)
            {
                if (ex is RankException) Console.WriteLine(ex.GetType());
                else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
            }

            finally
            {
                Console.WriteLine("Блок Finally сработал!");
            }

        }

        
    }
}
