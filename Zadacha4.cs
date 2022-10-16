namespace Zadacha4
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
            Console.WriteLine("ЗАДАЧА: на вход принимается целое число (N), а выдаются все чётные числа от 1 до (N) включительно.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите клавишу [Enter], что бы запустить задачу или [Q] для выхода...");
            Console.ResetColor();
        }
    }

    //ЗАДАЧА 4
    public class DZ
    {
        public void Start()
        {
            Console.ResetColor();
            Console.Clear();

            string str = "";
            int n;
            string rezult = "";

            //ввод числа n
            do
            {
                Console.Write("Введите число N: ");
                while (int.TryParse(str = Console.ReadLine()!, out n) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");
                    Console.ResetColor();
                    Console.Write("Введите число N: ");
                }
                n = int.Parse(str);

                if (n <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: число N должно быть больше 1!");
                    Console.ResetColor();
                }
            } while (n <= 1);


            //результат: все четные числа в диапозоне от 1 до N включительно
            for (int i = 2; i <= n; i += 2)
            {
                if (i == 2) rezult += i;
                else rezult += "; " + i;
            }
            Console.WriteLine("");
            Console.WriteLine("четные числа в диапазоне от 1 до " + n + " включительно: [" + rezult + "]");


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }



}