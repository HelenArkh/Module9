using System;

namespace Module9
{
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Sum1(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtraction (int a, int b)
        {
            Console.WriteLine(b - a);
        }


        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);

        public delegate string GreetingsDelegate(string name);

        delegate void ShowMessageDelegate(string _message);

        delegate int RandomNumberDelegate();

        delegate int Calculate(int a, int c);

        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () =>
            {
                return new Random().Next(0, 100);
            };
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();

        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }

        private static bool IsApple(string modelName)
        {
            if (modelName == "IPhone X") return true;
            else return false;
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }

        static void ShowMessage1()
        {
            Console.WriteLine("Метод 1");
        }

        static void ShowMessage2()
        {
            Console.WriteLine("Метод 2");
        }

        static void ShowMessage3()
        {
            Console.WriteLine("Метод 3");
        }

        static void ShowMessage4()
        {
            Console.WriteLine("Метод 4");
        }

       


    }
}
