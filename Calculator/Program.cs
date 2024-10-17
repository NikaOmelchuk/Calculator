using System;

namespace Calculator
{
    public class ProstOperatoin
    {
        public string operation(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return Convert.ToString(a + b);

                case '-':
                    return Convert.ToString(a - b);

                case '*':
                    return Convert.ToString(a * b);

                case '/':
                    if (b != 0)
                        return Convert.ToString(a / b);
                    else
                        return "На нуль дiлити не можна!";

                default:
                    return "Помилка!!";
            }
        }
    }

    public class Korin
    {
        public string operation(double a)
        {
            return Convert.ToString(Math.Sqrt(a));
        }
    }

    public class Stepin
    {
        public string operation(double a, double b)
        {
            return Convert.ToString(Math.Pow(a, b));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string n;
            ProstOperatoin po = new ProstOperatoin();
            Korin kor = new Korin();
            Stepin st = new Stepin();

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Простi операцiї");
                Console.WriteLine("2 - Корiнь числа");
                Console.WriteLine("3 - Пiднесення числа до степеня");
                Console.WriteLine("4 - Вихiд");
                Console.WriteLine();
                Console.Write("Введiть номер меню: ");
                n = Console.ReadLine();
                Console.WriteLine();

                switch (n)
                {
                    case "1":
                        Console.Write("Введiть перше число: ");
                        string a = Console.ReadLine();
                        Console.Write("Введiть друге число: ");
                        string b = Console.ReadLine();
                        Console.Write("Введiть операцію (+,-,*,/): ");
                        string op = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Результат: " + po.operation(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToChar(op)));
                     break;
                     case "2":
                        Console.Write("Введiть число, яке хочете поставити пiд корiнь: ");
                        string k = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Результат: " +kor.operation(Convert.ToDouble(k)));
                     break;
                    case "3":
                        Console.Write("Введiть число, яке хочете поставити у степiнь: ");
                        string ch = Console.ReadLine();
                        Console.Write("Введiть число, яке буде степенем: ");
                        string stup = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Результат: " + st.operation(Convert.ToDouble(ch), Convert.ToDouble(stup)));
                        break;
                }

            } while (Convert.ToInt32(n) != 4);
        }
    }
}

