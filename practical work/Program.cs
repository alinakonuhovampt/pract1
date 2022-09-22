Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");

int k = 0;
while (k <= 8)
{
    Console.WriteLine("Введите номер операции");
    string k1 = Console.ReadLine();
    int count = Convert.ToInt32(k1);

    k = count;

    if (count == 1)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        Console.WriteLine("Введите второе число ");
        string b1 = Console.ReadLine();
        int b = Convert.ToInt32(b1);

        int c = a + b;

        Console.WriteLine(a + " + " + b + " = " + c);
    }

    if (count == 2)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        Console.WriteLine("Введите второе число ");
        string b1 = Console.ReadLine();
        int b = Convert.ToInt32(b1);

        int c = b - a;

        Console.WriteLine(b + " - " + a + " = " + c);
    }

    if (count == 3)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        Console.WriteLine("Введите второе число ");
        string b1 = Console.ReadLine();
        int b = Convert.ToInt32(b1);

        int c = a * b;

        Console.WriteLine(a + " * " + b + " = " + c);
    }

    if (count == 4)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        Console.WriteLine("Введите второе число ");
        string b1 = Console.ReadLine();
        int b = Convert.ToInt32(b1);
        double c = a / b;
        Console.WriteLine(a + " / " + b + " = " + c);
    }

    if (count == 5)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        Console.WriteLine("Введите степень N ");
        string N1 = Console.ReadLine();
        int N = Convert.ToInt32(N1);

        int c = 1;
        for (int i = 1; i <= N; i++)
        {
            c *= a;
        }
        Console.WriteLine(a + " ^ " + N + " = " + c);
    }

    if (count == 6)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        double c = Math.Sqrt(a);

        Console.WriteLine("Квадратный корень из " + a + " = " + c);
    }

    if (count == 7)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        double a = Convert.ToInt32(a1);

        double c = a / 100;

        Console.WriteLine("1 процент от " + a + "= " + c);
    }

    if (count == 8)
    {
        Console.WriteLine("Введите первое число ");
        string a1 = Console.ReadLine();
        int a = Convert.ToInt32(a1);

        int c = 1;
        for (int i = 1; i <= a; i++)
        {
            c *= i;
        }
        Console.WriteLine(a + "! = " + c);
    }

}
Console.WriteLine("Покасики!!!");