namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil edin: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir operator daxil edin: ");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Add:
                    Console.Clear();
                    Addition(num1, num2);
                    break;

                case ConsoleKey.Subtract:
                    Console.Clear();
                    Subtraction(num1, num2);
                    break;

                case ConsoleKey.Multiply:
                    Console.Clear();
                    Multiplication(num1, num2);
                    break;

                case ConsoleKey.Divide:
                    Console.Clear();
                    Division(num1, num2);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Yanlis secim.");
                    break;
            }
        }

        public static void Addition(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
        }

        public static void Division(int num1, int num2)
        {
            Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
        }
    }
}