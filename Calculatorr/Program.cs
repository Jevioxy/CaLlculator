while (true)
{
    Double Первое, Второе;
    string str;
    string Операция;
    double степень;
    string stepen;



    Console.WriteLine("Выберите какую операцию вы хотите выполнить: ");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");




    Операция = Console.ReadLine();

    if (Операция == "9")
    {
        Environment.Exit(0);
    }

    Console.WriteLine("Введите первое число: ");

    str = Console.ReadLine();
    Первое = Convert.ToDouble(str);

    Console.WriteLine("Введите второе число");

    str = Console.ReadLine();
    Второе = Convert.ToDouble(str);

    switch (Операция)
    {

        case "1":
            Console.WriteLine(Первое + Второе);
            break;
        case "2":
            Console.WriteLine(Первое - Второе);
            break;
        case "3":
            Console.WriteLine(Первое * Второе);
            break;
        case "4":
            if (Первое == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(Первое / Второе);
            break;

        case "5":
            Console.WriteLine("Введите степень, в которое нужно возвести число: ");
            stepen = Console.ReadLine();
            степень = Convert.ToInt32(stepen);
            Console.WriteLine(Math.Pow(Первое, степень));
            break;

        case "6":
            Console.WriteLine(Math.Sqrt(Первое));
            break;

        case "7":
            Console.WriteLine(Первое * 0.01);
            break;
        case "8":
            double Факториал = 1;
            for (int i = 1; i <= Первое; i++)
            {
                Факториал = Факториал * i;
            }
            Console.WriteLine(Факториал);
            break;


        default:
            Console.WriteLine("error");
            break;
    }
}
