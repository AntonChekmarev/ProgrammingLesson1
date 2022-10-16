namespace Zadacha2
{
    //На случай самостоятельного запуска
    class Program
    {
        static void Main()
        {
            PrintMenu();

            ConsoleKey ck;
            do
            {
                ck = Console.ReadKey(true).Key;

                if (ck == ConsoleKey.Enter)
                {
                    DZ dz = new DZ();
                    dz.Start();

                    PrintMenu();
                }
            }
            while (ck != ConsoleKey.Q);
        }

        //отрисовка меню
        static void PrintMenu()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("ЗАДАЧА: на вход принимаются три целых числа и выдаётся большее значение среди них.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите клавишу [Enter], что бы запустить задачу или [Q] для выхода...");
            Console.ResetColor();
        }
    }

    //ЗАДАЧА 2
    public class DZ
    {
        public void Start()
        {
            Console.ResetColor();
            Console.Clear();

            string str = "";
            int a;
            int b;
            int c;
            int max;

            //ввод числа а
            Console.Write("Введите число a: ");
            while (int.TryParse(str = Console.ReadLine()!, out a) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("err: несоответствие типу integer!");
                Console.ResetColor();
                Console.Write("Введите число a: ");
            }
            a = int.Parse(str);

            //ввод числа b
            Console.Write("Введите число b: ");
            while (int.TryParse(str = Console.ReadLine()!, out b) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("err: несоответствие типу integer!");
                Console.ResetColor();
                Console.Write("Введите число b: ");
            }
            b = int.Parse(str);

            //ввод числа c
            do
            {
                Console.Write("Введите число c: ");
                while (int.TryParse(str = Console.ReadLine()!, out c) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");
                    Console.ResetColor();
                    Console.Write("Введите число c: ");
                }
                c = int.Parse(str);

                if (a == b && a == c && b == c)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: числа не должны быть одинаковыми!");
                    Console.ResetColor();
                }
            } while (a == b && a == c && b == c);

            //результат: большее
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            Console.WriteLine("");
            Console.WriteLine("значение [" + max + "] - большее.");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }



}