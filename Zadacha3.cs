namespace Zadacha3
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
            Console.WriteLine("ЗАДАЧА: на вход принимается целое число и выдаётся, является ли оно чётным.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите клавишу [Enter], что бы запустить задачу или [Q] для выхода...");
            Console.ResetColor();
        }
    }

    //ЗАДАЧА 3
    public class DZ
    {
        public void Start()
        {
            Console.ResetColor();
            Console.Clear();

            string str = "";
            int a;

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

            //результат: четное?
            Console.WriteLine("");
            if (a % 2 == 0) Console.WriteLine("число [" + a + "] - четное.");
            else Console.WriteLine("число [" + a + "] - НЕчетное.");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }



}