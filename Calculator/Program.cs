using System;
using System.Collections.Generic;

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

public class Elementy
    {
        public List<string> rez = new List<string>(); 

         public void PokazRez()
        {
            if (rez.Count == 0)
            {
                Console.WriteLine("Немає результатів.");
            }
            else
            {
                Console.WriteLine("Збережені результати:");
                for (int i = 0; i < rez.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + rez[i]);
                }
            }
        }

        public void YdalRez()
        {
            PokazRez();
            if (rez.Count > 0)
            {
                Console.Write("Введiть номер результату для видалення: ");
                int ind = Convert.ToInt32(Console.ReadLine()) - 1;

                if (ind >= 0 && ind < rez.Count)
                {
                    rez.RemoveAt(ind);
                    Console.WriteLine("Результат видалено.");
                }
                else
                {
                    Console.WriteLine("Неправильний індекс.");
                }
            }
        }

        public void ObnovRez()
        {
            PokazRez();
            if (rez.Count > 0)
            {
                Console.Write("Введiть номер результату для оновлення: ");
                int ind = int.Parse(Console.ReadLine()) - 1;

                if (ind >= 0 && ind < rez.Count)
                {
                    Console.Write("Введiть нове значення: ");
                    string newz = Console.ReadLine();
                    rez[ind] = newz;
                    Console.WriteLine("Результат оновлено.");
                }
                else
                {
                    Console.WriteLine("Неправильний індекс.");
                }
            }
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
            Elementy el = new Elementy();

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Простi операцiї");
                Console.WriteLine("2 - Корiнь числа");
                Console.WriteLine("3 - Пiднесення числа до степеня");
                Console.WriteLine("4 - Показати результати");
                Console.WriteLine("5 - Видалити результат");
                Console.WriteLine("6 - Оновити результат");
                Console.WriteLine("7 - Вихiд");
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
                        string rez1 = po.operation(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToChar(op));
                        Console.WriteLine("Результат: " + rez1);
                        el.rez.Add(rez1);
                     break;

                     case "2":
                        Console.Write("Введiть число, яке хочете поставити пiд корiнь: ");
                        string k = Console.ReadLine();
                        Console.WriteLine();
                        string rez2 = kor.operation(Convert.ToDouble(k));
                        Console.WriteLine("Результат: " + rez2);
                        el.rez.Add(rez2);
                     break;

                    case "3":
                        Console.Write("Введiть число, яке хочете поставити у степiнь: ");
                        string ch = Console.ReadLine();
                        Console.Write("Введiть число, яке буде степенем: ");
                        string stup = Console.ReadLine();
                        Console.WriteLine();
                        string rez3 = st.operation(Convert.ToDouble(ch), Convert.ToDouble(stup));
                        Console.WriteLine("Результат: " + rez3);
                        el.rez.Add(rez3);
                        break;

                        case "4":
                        el.PokazRez(); 
                        break;

                        case "5":
                        el.YdalRez(); 
                        break;

                        case "6":
                        el.ObnovRez(); 
                        break;

                        case "7":
                        break;

                        default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }

            } while (n != "7");
        }
    }
}

