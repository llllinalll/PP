////Задание 1
//Console.WriteLine("Введите 1-ое число:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите 2-ое число:");
//double  b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Выберите операцию: + - Сложение, - - Вычитание, / - Умножение, * - Деление");
//string p = Console.ReadLine();

//double r = 0;

//if (p == "+")
//{
//    r = a + b;
//    Console.WriteLine(r);
//}
//if (p == "-")
//{
//    r = a - b;
//    Console.WriteLine(r);
//}
//if (p == "/")
//{
//    r = a / b;
//    Console.WriteLine(r);
//}
//if (p == "*")
//{
//    r = a * b;
//    Console.WriteLine(r);
//}


///Задание 2

//Console.WriteLine("Введите строку:");
//string k = Console.ReadLine();
//int c = k.Length;

//string[] m = k.Split(',', ' ');
//int w = m.Length;

//string[] r = k.Split('.' , '?' , '!');
//int p = r.Length-1;

//Console.WriteLine("Вывод:");
//Console.WriteLine("Количество символов:" + c);
//Console.WriteLine("Количество слов:" + w);
//Console.WriteLine("Количество предложений:" + p);


///Задание 3
//Console.WriteLine("Таблица умножения");
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write($"{i} * {j} = {i * j}\t");
//    }
//    Console.WriteLine();
//}

//Задание 4

//Console.WriteLine("Введите число:");
//int r = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Факториал числа {r} = {Factorial(r)}");
//    static int Factorial(int n)
//{
//    if (n == 0)
//        return 1;
//    else
//        return n * Factorial(n - 1);
//}

//Задание 5 

//Console.Write("Введите количество чисел: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int a = 0;
//int b = 1;

//for (int i = 0; i < n; i++)
//{
//    Console.Write(a + " ");

//    int t = a;
//    a = b;
//    b = t + b;
//}


//Задание 6
//Console.WriteLine("Введите число n:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Простые числа:");
//for (int i = 2; i <= a; i++)
//{
//    bool m = true;
//    for (int j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            m = false;
//            break;
//        }
//    }
//    if (m)
//    {
//        Console.WriteLine(i);
//    }
//}

//Задание 7

//Random r = new Random();
//int t = r.Next(1, 101);
//int u = 0;
//int a = 0;

//Console.WriteLine("Угадайте число от 1 до 100:");

//while (u != t)
//{
//    Console.Write("Введите ваше предположение: ");
//    string i = Console.ReadLine();

//    if (int.TryParse(i, out u))
//    {
//        a++;

//        if (u != t)
//        {
//            Console.WriteLine(u < t ? "Загаданное число больше." : "Загаданное число меньше.");
//        }
//        else
//        {
//            Console.WriteLine($"Поздравляем! Вы угадали число {t} с {a} попытки(-ок).");
//        }
//    }
//}


//Задание 8

//Console.WriteLine("Выберите фигуру:");
//string a = Console.ReadLine();

//if(a == "круг")
//{
//    Console.WriteLine("Введите число:");
//    int r = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь круга равна:" + (3.14 * (r * r)));
//}
//if (a == "прямоугольник")
//{
//    Console.WriteLine("Введите число:");
//    int s = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int l = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь прямоугольника равна : " + (s*l));
//}
//if (a == "треугольник")
//{
//    Console.WriteLine("Введите число:");
//    int y = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int t = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int h = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь треугольника равна" + ((y + t + h) / 2));
//}

//Задание 9
Console.WriteLine("Выберите единицу измерения: \n1. Длинна\n2. Вес");
double s = double.Parse(Console.ReadLine());

if (s == 1)
{
    Console.Write("Введите длину в метрах: ");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мм\n2. см\n3. дм\n4. км");
    int l = int.Parse(Console.ReadLine());

    switch (l)
    {
        case 1: Console.WriteLine($"{m * 1000} мм"); break;
        case 2: Console.WriteLine($"{m * 100} см"); break;
        case 3: Console.WriteLine($"{m * 10} дм"); break;
        case 4: Console.WriteLine($"{m * 0.001} км"); break;
    }
}
else
{
    Console.Write("Введите вес в киллограммах: ");
    double e = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мг\n2. гр\n3. тонны\n4. пуды");
    int p = int.Parse(Console.ReadLine());

    switch (p)
    {
        case 1: Console.WriteLine($"{e * 1000000} мг"); break;
        case 2: Console.WriteLine($"{e * 1000} гр"); break;
        case 3: Console.WriteLine($"{e * 0,001} тонны"); break;
        case 4: Console.WriteLine($"{e * 0.06105} пуды"); break;
    }
}


