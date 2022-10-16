namespace Zadacha1
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
            Console.WriteLine("ЗАДАЧА: на вход принимаются два целых числа и выдаётся большее и меньшее значения среди них.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите клавишу [Enter], что бы запустить задачу или [Q] для выхода...");
            Console.ResetColor();
        }
    }

    //ЗАДАЧА 1
    public class DZ
    {
        public void Start()
        {
            Console.ResetColor();
            Console.Clear();

            string str = "";
            int a;
            int b;

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
            do
            {
                Console.Write("Введите число b: ");
                while (int.TryParse(str = Console.ReadLine()!, out b) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");
                    Console.ResetColor();
                    Console.Write("Введите число b: ");
                }
                b = int.Parse(str);

                if (a == b)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: числа не должны быть одинаковыми!");
                    Console.ResetColor();
                }
            } while (a == b);




            //результат: большее и меньшее
            Console.WriteLine("");
            if (a > b)
            {
                Console.WriteLine("значение [" + a + "] - большее.");
                Console.WriteLine("значение [" + b + "] - меньшее.");
            }
            else
            {
                Console.WriteLine("значение [" + a + "] - меньшее.");
                Console.WriteLine("значение [" + b + "] - большее.");

            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }



}