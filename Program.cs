try
{
    //Start
    PrintMainMenu();

    ConsoleKey ck;
    
    do
    {
        ck = Console.ReadKey(true).Key;
       
        if (ck == ConsoleKey.D1 || (ck) == ConsoleKey.NumPad1) // [1]
        {
            try
            {
                Zadacha1.DZ dz = new Zadacha1.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка выполнения Задачи 1: " + e.Message);
                Console.ResetColor();
                Console.Write("нажмите любую клавишу, для продолжения...");
                Console.ReadKey(true);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D2 || (ck) == ConsoleKey.NumPad2) // [2]
        {
            try
            {
                Zadacha2.DZ dz = new Zadacha2.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка выполнения Задачи 2: " + e.Message);
                Console.ResetColor();
                Console.Write("нажмите любую клавишу, для продолжения...");
                Console.ReadKey(true);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D3 || (ck) == ConsoleKey.NumPad3) // [3]
        {
            try
            {
                Zadacha3.DZ dz = new Zadacha3.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка выполнения Задачи 3: " + e.Message);
                Console.ResetColor();
                Console.Write("нажмите любую клавишу, для продолжения...");
                Console.ReadKey(true);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D4 || (ck) == ConsoleKey.NumPad4) // [4]
        {
            try
            {
                Zadacha4.DZ dz = new Zadacha4.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка выполнения Задачи 4: " + e.Message);
                Console.ResetColor();
                Console.Write("нажмите любую клавишу, для продолжения...");
                Console.ReadKey(true);
            }
            PrintMainMenu();
        }
    }
    while (ck != ConsoleKey.Q);
    //Finish
}
catch (Exception e)
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Critical Error in Logic: " + e.Message);
    Console.ResetColor();
    Console.Write("нажмите любую клавишу, для закрытия программы...");
    Console.ReadKey(true);
}


//отрисовка главного меню
void PrintMainMenu()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("");
    Console.Write("[1] Задача: ");
    Console.ResetColor();
    Console.WriteLine("на вход принимаются два целых числа и выдаётся большее и меньшее значения среди них.");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[2] Задача: ");
    Console.ResetColor();
    Console.WriteLine("на вход принимаются три целых числа и выдаётся большее значение среди них.");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[3] Задача: ");
    Console.ResetColor();
    Console.WriteLine("на вход принимается целое число и выдаётся, является ли оно чётным.");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[4] Задача: ");
    Console.ResetColor();
    Console.WriteLine("на вход принимается целое число (N), а выдаются все чётные числа от 1 до (N) включительно.");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("инициируйте выполнение Задач клавишами [1] [2] [3] [4] или нажмите [Q] для выхода из программы...");

    Console.ResetColor();
}