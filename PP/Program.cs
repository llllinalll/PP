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
//Console.WriteLine("Выберите единицу измерения: \n1. Длинна\n2. Вес");
//double s = double.Parse(Console.ReadLine());

//if (s == 1)
//{
//    Console.Write("Введите длину в метрах: ");
//    double m = double.Parse(Console.ReadLine());
//    Console.WriteLine("Выбор: \n1. мм\n2. см\n3. дм\n4. км");
//    int l = int.Parse(Console.ReadLine());

//    switch (l)
//    {
//        case 1: Console.WriteLine($"{m * 1000} мм"); break;
//        case 2: Console.WriteLine($"{m * 100} см"); break;
//        case 3: Console.WriteLine($"{m * 10} дм"); break;
//        case 4: Console.WriteLine($"{m * 0.001} км"); break;
//    }
//}
//else
//{
//    Console.Write("Введите вес в киллограммах: ");
//    double e = double.Parse(Console.ReadLine());
//    Console.WriteLine("Выбор: \n1. мг\n2. гр\n3. тонны\n4. пуды");
//    int p = int.Parse(Console.ReadLine());

//    switch (p)
//    {
//        case 1: Console.WriteLine($"{e * 1000000} мг"); break;
//        case 2: Console.WriteLine($"{e * 1000} гр"); break;
//        case 3: Console.WriteLine($"{e * 0,001} тонны"); break;
//        case 4: Console.WriteLine($"{e * 0.06105} пуды"); break;
//    }
//}

////Задание 10
//Console.WriteLine("Введите число:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите процент :");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{z}% от {a} равен {(a / 100) * z}");

//Задание 11
//Console.WriteLine("Введите сумму:");
//double sum = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Выбор: \n1. Евро в рубли\n2. Рубли в евро");
//int h = Convert.ToInt32(Console.ReadLine());
//if (h == 1)
//{
//    Console.WriteLine(sum * 97.81);
//}
//else
//if (h == 2)
//{
//    Console.WriteLine(sum / 97.81);
//}

//Задание 12

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}

//int min = a.Min();
//int indexMin = Array.IndexOf(a, min);
//Console.WriteLine("Минимальное:" + min);
//Console.WriteLine("Индекс минимального:" + indexMin);


//int max = a.Max();
//int indexMax = Array.IndexOf(a, max);
//Console.WriteLine("Максимальное:" + max);
//Console.WriteLine("Индекс максимального:" + indexMax);

// Задание 13
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//}

//Console.WriteLine("Исходный массив:");
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (пузырьком):");
//BubbleSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (пузырьком):");
//BubbleSort(a, false);
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (вставками):");
//InsertionSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (вставками):");
//InsertionSort(a, false);
//PrintArray(a);


//// Метод для сортировки пузырьком
//static void BubbleSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if ((g && a[j] > a[j + 1]) || (!g && a[j] < a[j + 1]))
//            {
//                int t = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = t;
//            }
//        }
//    }
//}

//// Метод для сортировки вставками
//static void InsertionSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 1; i < n; i++)
//    {
//        int k = a[i];
//        int j = i - 1;

//        while (j >= 0 && ((g && a[j] > k) || (!g && a[j] < k)))
//        {
//            a[j + 1] = a[j];
//            j = j - 1;
//        }
//        a[j + 1] = k;
//    }
//}

//// Метод для вывода массива
//static void PrintArray(int[] a)
//{
//    Console.WriteLine(string.Join(", ", a));
//}

// Задание 14

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Введите элемент для поиска:");
//int m = int.Parse(Console.ReadLine());

//int index = Array.IndexOf(a, m);

//if (index >= 0)
//{
//    Console.WriteLine($"Число {m} найдено на индексе {index}.");

//}
//else
//{
//    Console.WriteLine("Число не найдено.");
//}

//Задание 15

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Массив в обратном порядке:");

//// Вывод элементов массива в обратном порядке
//for (int i = a.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(a[i]);
//}

//Задание 16

//    int[,] A = { { 1, 2 }, { 3, 4 } }; int[,] B = { { 5, 6 }, { 7, 8 } };
//    // Сложение
//    Console.WriteLine("Сложение:"); PrintMatrix(Add(A, B));
//    // Вычитание
//    Console.WriteLine("\nВычитание:"); PrintMatrix(Subtract(A, B));
//    // Умножение
//    Console.WriteLine("\nУмножение:"); PrintMatrix(Multiply(A, B));
//    // Транспонирование
//    Console.WriteLine("\nТранспонирование A:"); PrintMatrix(Transpose(A));
//    Console.WriteLine("\nТранспонирование B:"); PrintMatrix(Transposeу(B));

//static int[,] Add(int[,] A, int[,] B) => new int[,]
//    {             { A[0, 0] + B[0, 0], A[0, 1] + B[0, 1] },
//        { A[1, 0] + B[1, 0], A[1, 1] + B[1, 1] }         };
//static int[,] Subtract(int[,] A, int[,] B) =>
//    new int[,]         {
//        { A[0, 0] - B[0, 0], A[0, 1] - B[0, 1] },             { A[1, 0] - B[1, 0], A[1, 1] - B[1, 1] }
//    };
//static int[,] Multiply(int[,] A, int[,] B) => new int[,]
//    {             { A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0], A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] },
//        { A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0], A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] }         };
//static int[,] Transpose(int[,] A) =>
//    new int[,]         {
//        { A[0, 0], A[1, 0] },             { A[0, 1], A[1, 1] }
//    };
//static int[,] Transposeу(int[,] B) =>
//    new int[,]         {
//        { B[0, 0], B[1, 0] },             { B[0, 1], B[1, 1] }
//    };
//static void PrintMatrix(int[,] matrix)
//{
//    Console.WriteLine($"{matrix[0, 0]} {matrix[0, 1]}"); Console.WriteLine($"{matrix[1, 0]} {matrix[1, 1]}");
//}

//17 задание


//Console.WriteLine("Введите число в десятичной системе:");
//int n = int.Parse(Console.ReadLine());

//// Перевод в другие системы счисления
//string b = Convert.ToString(n, 2);
//string o = Convert.ToString(n, 8);
//string l = Convert.ToString(n, 16);

//Console.WriteLine($"Двоичная: {b}");
//Console.WriteLine($"Восьмеричная: {o}");
//Console.WriteLine($"Шестнадцатеричная: {l.ToUpper()}");


// 18 задание

//Console.WriteLine("Введите количество уровней пирамиды: ");
//int s = int.Parse(Console.ReadLine());
//Console.WriteLine("Пирамида:");

//for (int i = 1; i <= s; i++)
//{
//    Печатаем пробелы перед числами
//    for (int j = 1; j <= s - i; j++)
//    {
//        Console.Write(" ");
//    }

//    Печатаем числа
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write(k);
//    }

//    Печатаем числа в обратном порядке
//    for (int l = i - 1; l >= 1; l--)
//    {
//        Console.Write(l);
//    }

//    Console.WriteLine();
//}

//19 Задание

//// Ввод строки
//Console.WriteLine("Введите строку: ");
//string g = Console.ReadLine();

//// Ввод подстроки
//Console.WriteLine("Введите подстроку для поиска: ");
//string n = Console.ReadLine();

//// Поиск индекса подстроки
//int index = g.IndexOf(n);

//// Проверка и вывод результата
//if (index != -1)
//{
//    Console.WriteLine($"Подстрока найдена на позиции: {index}");
//}
//else
//{
//    Console.WriteLine("Подстрока не найдена.");
//}


//20 задание


//Console.WriteLine("Введите строку с лишними пробелами: ");
//string inputString = Console.ReadLine();

//// Разделение строки по пробелам, удаление пустых частей и объединение с одним пробелом
//string resultString = string.Join(" ", inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

//// Вывод результата
//Console.WriteLine($"Строка после удаления лишних пробелов: \n'{resultString}'");


// 21 Задание

//Console.WriteLine("Введите первую дату (ГГГГ-ММ-ДД): ");
//DateTime date1 = DateTime.Parse(Console.ReadLine());

//// Ввод второй даты
//Console.WriteLine("Введите вторую дату (ГГГГ-ММ-ДД): ");
//DateTime date2 = DateTime.Parse(Console.ReadLine());

//// Вычисление разницы в днях
//int daysDifference = Math.Abs((date2 - date1).Days);

//// Вывод результата
//Console.WriteLine($"Количество дней между датами: {daysDifference}");


// 22 Задание
//using System.Text.RegularExpressions;

//Console.WriteLine("Введите номер телефона (например, +7 (123) 456-78-90):");
//string phoneNumber = Console.ReadLine();
//if (IsValidRussianPhoneNumber(phoneNumber))
//{
//    Console.WriteLine("Номер телефона введен корректно.");
//}
//else
//{
//    Console.WriteLine("Номер телефона введен некорректно.");
//}

//Console.WriteLine("Введите e-mail (например, example@example.com):");
//string email = Console.ReadLine();
//if (IsValidEmail(email))
//{
//    Console.WriteLine("E-mail введен корректно.");
//}
//else
//{
//    Console.WriteLine("E-mail введен некорректно.");
//}


//    static bool IsValidRussianPhoneNumber(string phoneNumber)
//{
//    // Регулярное выражение для проверки российского номера телефона
//    string pattern = @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$";
//    return Regex.IsMatch(phoneNumber, pattern);
//}

//static bool IsValidEmail(string email)
//{
//    // Регулярное выражение для проверки e-mail
//    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//    return Regex.IsMatch(email, pattern);
//}

// 23 Задание

//using System.Text;

//        Console.WriteLine("Введите длину пароля:");
//        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
//        {
//            string password = GenerateRandomPassword(length);
//            Console.WriteLine($"Сгенерированный пароль: {password}");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: введите положительное целое число.");
//        }


//    static string GenerateRandomPassword(int length)
//    {
//        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?/[]{}|";


//        string allChars = upperCase;
//        StringBuilder password = new StringBuilder(length);
//        Random random = new Random();

//        for (int i = 0; i < length; i++)
//        {
//            char randomChar = allChars[random.Next(allChars.Length)];
//            password.Append(randomChar);
//        }

//        return password.ToString();
//    }


// 24 Задание

//decimal totalAmount = 0m;
//string input;
//const decimal vatRate = 0.20m; // НДС 20%

//Console.WriteLine("Введите список покупок и их стоимость. Введите 'done', чтобы завершить ввод.");

//while (true)
//{
//    Console.Write("Введите название товара (или 'done' для завершения): ");
//    input = Console.ReadLine();
//    if (input.ToLower() == "done") break;

//    Console.Write("Введите стоимость товара (или 'done' для завершения): ");
//    input = Console.ReadLine();
//    if (input.ToLower() == "done") break;

//    if (decimal.TryParse(input, out decimal itemPrice) && itemPrice >= 0)
//    {
//        totalAmount += itemPrice;
//    }
//    else
//    {
//        Console.WriteLine("Некорректная стоимость. Попробуйте снова.");
//    }
//}

//decimal vatAmount = totalAmount * vatRate;
//decimal totalWithVat = totalAmount + vatAmount;

//Console.WriteLine("\n--- Чек ---");

//Console.WriteLine($"Итоговая сумма: {totalAmount:C}");
//Console.WriteLine($"НДС (20%): {vatAmount:C}");
//Console.WriteLine($"Итог с НДС: {totalWithVat:C}");


// 25 Задание 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Ввод текста
//        Console.WriteLine("Введите текст:");
//        string input = Console.ReadLine();

//        // Разбиение текста на слова и подсчет частоты
//        var wordCount = input.ToLower()
//                             .Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
//                             .GroupBy(word => word)
//                             .ToDictionary(group => group.Key, group => group.Count());

//        // Вывод результата
//        Console.WriteLine("\nЧастота слов:");
//        foreach (var word in wordCount)
//        {
//            Console.WriteLine($"{word.Key}: {word.Value}");
//        }
//    }
//}



//26 Задание

//Console.WriteLine("Введите время в формате (ЧЧ:ММ)");
//string a = Console.ReadLine();
//DateTime p = DateTime.Parse(a);
//Console.WriteLine("Введите время в формате (ЧЧ:ММ) для сложения или вычитания");
//string s = Console.ReadLine();
//DateTime o = DateTime.Parse(s);
//Console.WriteLine("Выберите что вы хотите сделать: 1- Сложить минуты, 2- Сложить часы, 3-Вычесть часы, 4- Вычесть минуты");
//int z = Convert.ToInt32(Console.ReadLine());
//switch (z)
//{
//    case 1:
//        var date = p.AddMinutes(o.Minute);
//        Console.WriteLine($"{DateTime.Parse(date.ToString())}"); break;
//    case 2:
//        var date1 = p.AddHours(o.Hour);
//        Console.WriteLine($"{DateTime.Parse(date1.ToString())}"); break;
//    case 3:
//        var date2 = p.Hour - o.Hour;
//        Console.WriteLine($"{date2}"); break;
//    case 4:
//        var date3 = p.Minute - o.Minute;
//        Console.WriteLine($"{date3}"); break;
//}


//27 Задание
//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.WriteLine("Решение квадратного уравнения");        
//        Console.Write("a = "); 
//        var a = double.Parse(Console.ReadLine());
//        Console.Write("b = ");
//        var b = double.Parse(Console.ReadLine());
//        Console.Write("c = ");
//        var c = double.Parse(Console.ReadLine());
//        double x1, x2;

//        var discriminant = Math.Pow(b, 2) - 4 * a * c;
//        if (discriminant < 0)
//        {
//            Console.WriteLine("Квадратное уравнение не имеет корней");
//        }
//        else
//        {
//            if (discriminant == 0) 
//            {
//                x1 = -b / (2 * a);
//                x2 = x1;
//            }
//            else 
//                 {
//                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//        }           
//        Console.WriteLine($"x1 = {x1}; x2 = {x2}");
//    }

//    Console.WriteLine("Для выхода нажмите любую клавишу...");
//        Console.ReadKey(true);    
//       }
//}

//28 Задание

//// Ввод коэффициентов уравнений
//Console.WriteLine("Введите коэффициенты первого уравнения (a1, b1, c1):");
//double a1 = Convert.ToDouble(Console.ReadLine());
//double b1 = Convert.ToDouble(Console.ReadLine());
//double c1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Введите коэффициенты второго уравнения (a2, b2, c2):");
//double a2 = Convert.ToDouble(Console.ReadLine());
//double b2 = Convert.ToDouble(Console.ReadLine());
//double c2 = Convert.ToDouble(Console.ReadLine());

//// Решение системы уравнений методом подстановки
//// Если b1 не равен 0, решаем первое уравнение для y
//if (b1 != 0)
//{
//    // Решаем первое уравнение для y
//    double y = (c1 - a1 * (c2 - a2 * 0) / a2) / b1;

//    // Подставляем найденное значение y во второе уравнение, чтобы найти x
//    double x = (c1 - b1 * y) / a1;

//    Console.WriteLine($"Решение системы уравнений: x = {x}, y = {y}");
//}
//else
//{
//    // Если b1 равно 0, решаем второе уравнение для y
//    if (b2 != 0)
//    {
//        double y = (c2 - a2 * (c1 - a1 * 0) / a1) / b2;

//        // Подставляем найденное значение y в первое уравнение, чтобы найти x
//        double x = (c1 - b1 * y) / a1;

//        Console.WriteLine($"Решение системы уравнений: x = {x}, y = {y}");
//    }
//    else
//    {
//        Console.WriteLine("Не удалось решить систему уравнений. Проверьте коэффициенты.");
//    }
//}

//29 Задание


//    // Получаем все диски на компьютере
//    DriveInfo[] drives = DriveInfo.GetDrives();

//    // Перебираем все диски и выводим информацию о каждом
//    foreach (DriveInfo drive in drives)
//    {
//        Console.WriteLine($"Диск: {drive.Name}");

//        if (drive.IsReady)
//        {
//            Console.WriteLine($"Файловая система: {drive.DriveFormat}");
//            Console.WriteLine($"Размер: {FormatBytes(drive.TotalSize)}");
//            Console.WriteLine($"Свободно: {FormatBytes(drive.AvailableFreeSpace)}");
//            Console.WriteLine($"Использовано: {FormatBytes(drive.TotalSize - drive.AvailableFreeSpace)}");
//        }
//        else
//        {
//            Console.WriteLine("Диск не готов.");
//        }

//        Console.WriteLine(); // Пустая строка для разделения информации о дисках
//    }


//// Метод для форматирования байтов в читаемый формат
//static string FormatBytes(long bytes)
//{
//    // Форматируем байты в ГБ, МБ, КБ или байты
//    if (bytes >= 1L << 30) return $"{bytes >> 30} ГБ";
//    if (bytes >= 1L << 20) return $"{bytes >> 20} МБ";
//    if (bytes >= 1L << 10) return $"{bytes >> 10} КБ";
//    return $"{bytes} байт";
//}


// 30 Задание 

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Выберите операцию:");
//            Console.WriteLine("1. Создать файл");
//            Console.WriteLine("2. Удалить файл");
//            Console.WriteLine("3. Копировать файл");
//            Console.WriteLine("4. Переместить файл");
//            Console.WriteLine("5. Выйти");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    CreateFile();
//                    break;
//                case "2":
//                    DeleteFile();
//                    break;
//                case "3":
//                    CopyFile();
//                    break;
//                case "4":
//                    MoveFile();
//                    break;
//                case "5":
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//    }

//    static void CreateFile()
//    {
//        Console.Write("Введите путь к файлу: ");
//        string path = Console.ReadLine();

//        try
//        {
//            File.WriteAllText(path, ""); // Создаем пустой файл
//            Console.WriteLine("Файл создан.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    static void DeleteFile()
//    {
//        Console.Write("Введите путь к файлу: ");
//        string path = Console.ReadLine();

//        try
//        {
//            if (File.Exists(path))
//            {
//                File.Delete(path);
//                Console.WriteLine("Файл удален.");
//            }
//            else
//            {
//                Console.WriteLine("Файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    static void CopyFile()
//    {
//        Console.Write("Введите путь к исходному файлу: ");
//        string sourcePath = Console.ReadLine();

//        Console.Write("Введите путь к целевому файлу: ");
//        string destPath = Console.ReadLine();

//        try
//        {
//            if (File.Exists(sourcePath))
//            {
//                File.Copy(sourcePath, destPath, true);
//                Console.WriteLine("Файл скопирован.");
//            }
//            else
//            {
//                Console.WriteLine("Исходный файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    static void MoveFile()
//    {
//        Console.Write("Введите путь к исходному файлу: ");
//        string sourcePath = Console.ReadLine();

//        Console.Write("Введите путь к новому файлу: ");
//        string destPath = Console.ReadLine();

//        try
//        {
//            if (File.Exists(sourcePath))
//            {
//                File.Move(sourcePath, destPath);
//                Console.WriteLine("Файл перемещен.");
//            }
//            else
//            {
//                Console.WriteLine("Исходный файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}

//31 Задание

//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;

//class Program
//{
//    // Класс для представления данных
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    static void Main()
//    {
//        // Путь к JSON-файлу
//        string filePath = "pp.json";

//        try
//        {

//            // Чтение и десериализация JSON-файла
//            string json = File.ReadAllText(filePath);
//            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);

//            // Вывод данных в формате таблицы
//            Console.WriteLine("Id   Name      Age");
//            Console.WriteLine("-----------------");
//            foreach (var person in people)
//            {
//                Console.WriteLine($"{person.Id,-4} {person.Name,-8} {person.Age,2}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}


//32 Задание

//using System;
//using System.Collections.Generic;
//using System.Xml.Linq;

//class Program
//{
//    // Класс для представления данных
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    static void Main()
//    {
//        // Путь к XML-файлу
//        string filePath = "pp.xml";

//        try
//        {
//            // Загрузка XML-файла
//            XDocument doc = XDocument.Load(filePath);

//            // Извлечение данных из XML в список объектов Person
//            List<Person> people = new List<Person>();

//            foreach (XElement element in doc.Descendants("Person"))
//            {
//                Person person = new Person
//                {
//                    Id = (int)element.Element("Id"),
//                    Name = (string)element.Element("Name"),
//                    Age = (int)element.Element("Age")
//                };
//                people.Add(person);
//            }

//            // Вывод данных в формате таблицы
//            Console.WriteLine("Id   Name      Age");
//            Console.WriteLine("-----------------");
//            foreach (var person in people)
//            {
//                Console.WriteLine($"{person.Id,-4} {person.Name,-8} {person.Age,2}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}


//33 Задание

//using System;
//using System.IO;

//class Program
//{
//    static string filePath = "tasks.txt";

//    static void Main()
//    {
//        // Создание файла, если его нет
//        if (!File.Exists(filePath))
//        {
//            File.Create(filePath).Close();
//        }

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("1. Просмотреть задачи");
//            Console.WriteLine("2. Добавить задачу");
//            Console.WriteLine("3. Удалить задачу");
//            Console.WriteLine("4. Отметить задачу как выполненную");
//            Console.WriteLine("5. Выйти");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    ViewTasks();
//                    break;
//                case "2":
//                    AddTask();
//                    break;
//                case "3":
//                    DeleteTask();
//                    break;
//                case "4":
//                    MarkTaskAsDone();
//                    break;
//                case "5":
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//    }

//    static void ViewTasks()
//    {
//        Console.Clear();
//        string[] tasks = File.ReadAllLines(filePath);
//        for (int i = 0; i < tasks.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}. {tasks[i]}");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void AddTask()
//    {
//        Console.Clear();
//        Console.Write("Введите новую задачу: ");
//        string task = Console.ReadLine();
//        File.AppendAllText(filePath, $"[ ] {task}\n");
//        Console.WriteLine("Задача добавлена. Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void DeleteTask()
//    {
//        Console.Clear();
//        Console.Write("Введите номер задачи для удаления: ");
//        if (int.TryParse(Console.ReadLine(), out int index) && index > 0)
//        {
//            string[] tasks = File.ReadAllLines(filePath);
//            if (index <= tasks.Length)
//            {
//                File.WriteAllLines(filePath, RemoveTask(tasks, index - 1));
//                Console.WriteLine("Задача удалена. Нажмите любую клавишу для продолжения...");
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер задачи.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод.");
//        }
//        Console.ReadKey();
//    }

//    static void MarkTaskAsDone()
//    {
//        Console.Clear();
//        Console.Write("Введите номер задачи, чтобы отметить её как выполненную: ");
//        if (int.TryParse(Console.ReadLine(), out int index) && index > 0)
//        {
//            string[] tasks = File.ReadAllLines(filePath);
//            if (index <= tasks.Length)
//            {
//                string task = tasks[index - 1];
//                if (!task.StartsWith("[x] "))
//                {
//                    tasks[index - 1] = "[x] " + task.Substring(4);
//                    File.WriteAllLines(filePath, tasks);
//                    Console.WriteLine("Задача отмечена как выполненная.");
//                }
//                else
//                {
//                    Console.WriteLine("Задача уже выполнена.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер задачи.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод.");
//        }
//        Console.ReadKey();
//    }

//    static string[] RemoveTask(string[] tasks, int index)
//    {
//        if (index >= 0 && index < tasks.Length)
//        {
//            var newList = new System.Collections.Generic.List<string>(tasks);
//            newList.RemoveAt(index);
//            return newList.ToArray();
//        }
//        return tasks;
//    }
//}


//34 Задание 

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        
//        string inputFilePath = "input.txt";
//        string outputFilePath = "output.txt";
//        Создание файла, если его нет

//        try
//        {
//          
//            string text = File.ReadAllText(inputFilePath);

//        
//            string convertedText = ConvertCase(text);

//     
//            File.WriteAllText(outputFilePath, convertedText);

//            Console.WriteLine("Текст успешно преобразован и записан в файл.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    static string ConvertCase(string input)
//    {

//        return string.Concat(Array.ConvertAll(input.ToCharArray(), c =>
//            char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
//    }
//}


//35  Задание

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;

//class Program
//{
//    static string notesFilePath = "notes.txt";
//    static Dictionary<int, string> notes = new Dictionary<int, string>();

//    static void Main()
//    {
//        LoadNotes();

//        while (true)
//        {
//            Console.Clear();
//            ShowCalendar();
//            Console.WriteLine("\nВведите день для добавления/просмотра заметки (или нажмите Enter для выхода):");
//            string input = Console.ReadLine();

//            if (string.IsNullOrEmpty(input))
//                break;

//            if (int.TryParse(input, out int day) && day >= 1 && day <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
//            {
//                Console.WriteLine("Введите заметку (оставьте пустым для удаления заметки):");
//                string note = Console.ReadLine();

//                if (string.IsNullOrEmpty(note))
//                    notes.Remove(day);
//                else
//                    notes[day] = note;

//                SaveNotes();
//            }
//            else
//            {
//                Console.WriteLine("Неверный день.");
//            }
//        }
//    }

//    static void ShowCalendar()
//    {
//        DateTime now = DateTime.Now;
//        int year = now.Year;
//        int month = now.Month;
//        DateTime firstDay = new DateTime(year, month, 1);
//        int daysInMonth = DateTime.DaysInMonth(year, month);
//        int startDay = (int)firstDay.DayOfWeek;
//        if (startDay == 0) startDay = 6; // Пн-Вс

//        Console.WriteLine($"Календарь на {now.ToString("MMMM yyyy", CultureInfo.CurrentCulture)}");
//        Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

//        for (int i = 0; i < startDay; i++)
//            Console.Write("   ");

//        for (int day = 1; day <= daysInMonth; day++)
//        {
//            if (notes.ContainsKey(day))
//                Console.ForegroundColor = ConsoleColor.Green;

//            Console.Write($"{day,2} ");
//            Console.ResetColor();

//            if ((day + startDay) % 7 == 0)
//                Console.WriteLine();
//        }
//        Console.WriteLine();
//    }

//    static void LoadNotes()
//    {
//        if (File.Exists(notesFilePath))
//        {
//            foreach (var line in File.ReadAllLines(notesFilePath))
//            {
//                var parts = line.Split(':', 2);
//                if (parts.Length == 2 && int.TryParse(parts[0], out int day))
//                    notes[day] = parts[1];
//            }
//        }
//    }

//    static void SaveNotes()
//    {
//        File.WriteAllLines(notesFilePath, notes.Select(n => $"{n.Key}:{n.Value}"));
//    }
//}

//
//36 Задание 

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static string dataFilePath = "students.txt";
//    static Dictionary<string, Student> students = new Dictionary<string, Student>();
//
//    static void Main()
//    {
//        LoadData();

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("1. Просмотреть студентов");
//            Console.WriteLine("2. Добавить студента");
//            Console.WriteLine("3. Добавить оценку");
//            Console.WriteLine("4. Удалить студента");
//            Console.WriteLine("5. Выйти");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    ViewStudents();
//                    break;
//                case "2":
//                    AddStudent();
//                    break;
//                case "3":
//                    AddGrade();
//                    break;
//                case "4":
//                    RemoveStudent();
//                    break;
//                case "5":
//                    SaveData();
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//    }

//    static void LoadData()
//    {
//        if (File.Exists(dataFilePath))
//        {
//            var lines = File.ReadAllLines(dataFilePath);
//            foreach (var line in lines)
//            {
//                var parts = line.Split(';');
//                if (parts.Length < 2)
//                    continue;

//                var studentId = parts[0];
//                var studentName = parts[1];
//                var student = new Student { Id = studentId, Name = studentName };

//                for (int i = 2; i < parts.Length; i += 2)
//                {
//                    if (i + 1 < parts.Length)
//                    {
//                        var subject = parts[i];
//                        if (int.TryParse(parts[i + 1], out int grade))
//                        {
//                            student.Grades[subject] = grade;
//                        }
//                    }
//                }

//                students[studentId] = student;
//            }
//        }
//    }
//
//    static void SaveData()
//    {
//        var lines = students.Values.Select(s =>
//        {
//            var grades = string.Join(";", s.Grades.Select(g => $"{g.Key};{g.Value}"));
//            return $"{s.Id};{s.Name};{grades}";
//        });

//        File.WriteAllLines(dataFilePath, lines);
//    }

//    static void ViewStudents()
//    {
//        Console.Clear();
//        Console.WriteLine("Список студентов:");
//        foreach (var student in students.Values)
//        {
//            Console.WriteLine($"ID: {student.Id}, Имя: {student.Name}");
//            foreach (var grade in student.Grades)
//            {
//                Console.WriteLine($"  {grade.Key}: {grade.Value}");
//            }
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void AddStudent()
//    {
//        Console.Clear();
//        Console.Write("Введите ID студента: ");
//        var id = Console.ReadLine();
//        if (students.ContainsKey(id))
//        {
//            Console.WriteLine("Студент с таким ID уже существует.");
//            return;
//        }

//        Console.Write("Введите имя студента: ");
//        var name = Console.ReadLine();
//        students[id] = new Student { Id = id, Name = name };
//        Console.WriteLine("Студент добавлен.");
//        Console.ReadKey();
//    }

//    static void AddGrade()
//    {
//        Console.Clear();
//        Console.Write("Введите ID студента: ");
//        var id = Console.ReadLine();

//        if (!students.ContainsKey(id))
//        {
//            Console.WriteLine("Студент с таким ID не найден.");
//            return;
//        }

//        var student = students[id];
//        Console.Write("Введите предмет: ");
//        var subject = Console.ReadLine();
//        Console.Write("Введите оценку: ");
//        if (int.TryParse(Console.ReadLine(), out int grade))
//        {
//            student.Grades[subject] = grade;
//            Console.WriteLine("Оценка добавлена.");
//        }
//        else
//        {
//            Console.WriteLine("Неверная оценка.");
//        }
//        Console.ReadKey();
//    }

//    static void RemoveStudent()
//    {
//        Console.Clear();
//        Console.Write("Введите ID студента для удаления: ");
//        var id = Console.ReadLine();

//        if (students.Remove(id))
//        {
//            Console.WriteLine("Студент удален.");
//        }
//        else
//        {
//            Console.WriteLine("Студент с таким ID не найден.");
//        }
//        Console.ReadKey();
//    }
//}

//class Student
//{
//    public string Id { get; set; }
//    public string Name { get; set; }
//    public Dictionary<string, int> Grades { get; set; } = new Dictionary<string, int>();
//}


//37 Задание

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static List<Contact> contacts = new List<Contact>();

//    static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("1. Добавить контакт");
//            Console.WriteLine("2. Удалить контакт");
//            Console.WriteLine("3. Редактировать контакт");
//            Console.WriteLine("4. Поиск контакта");
//            Console.WriteLine("5. Показать все контакты");
//            Console.WriteLine("0. Выход");
//            Console.Write("Выберите действие: ");

//            switch (Console.ReadLine())
//            {
//                case "1": AddContact(); break;
//                case "2": DeleteContact(); break;
//                case "3": EditContact(); break;
//                case "4": SearchContact(); break;
//                case "5": ShowAllContacts(); break;
//                case "0": return;
//            }
//        }
//    }

//    static void AddContact()
//    {
//        Console.Write("Имя: ");
//        string name = Console.ReadLine();
//        Console.Write("Телефон: ");
//        string phone = Console.ReadLine();
//        Console.Write("Email: ");
//        string email = Console.ReadLine();
//        contacts.Add(new Contact(name, phone, email));
//        Console.WriteLine("Контакт добавлен. Нажмите любую клавишу.");
//        Console.ReadKey();
//    }

//    static void DeleteContact()
//    {
//        Console.Write("Имя для удаления: ");
//        string name = Console.ReadLine();
//        contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
//        Console.WriteLine("Контакт удален. Нажмите любую клавишу.");
//        Console.ReadKey();
//    }

//    static void EditContact()
//    {
//        Console.Write("Имя для редактирования: ");
//        string name = Console.ReadLine();
//        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
//        if (contact != null)
//        {
//            Console.Write("Новый телефон: ");
//            contact.Phone = Console.ReadLine();
//            Console.Write("Новый email: ");
//            contact.Email = Console.ReadLine();
//            Console.WriteLine("Контакт обновлен.");
//        }
//        else
//        {
//            Console.WriteLine("Контакт не найден.");
//        }
//        Console.WriteLine("Нажмите любую клавишу.");
//        Console.ReadKey();
//    }

//    static void SearchContact()
//    {
//        Console.Write("Имя для поиска: ");
//        string name = Console.ReadLine();
//        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
//        Console.WriteLine(contact != null ? contact.ToString() : "Контакт не найден.");
//        Console.WriteLine("Нажмите любую клавишу.");
//        Console.ReadKey();
//    }

//    static void ShowAllContacts()
//    {
//        Console.WriteLine(contacts.Count > 0 ? string.Join(Environment.NewLine, contacts) : "Нет контактов.");
//        Console.WriteLine("Нажмите любую клавишу.");
//        Console.ReadKey();
//    }
//}

//class Contact
//{
//    public string Name { get; set; }
//    public string Phone { get; set; }
//    public string Email { get; set; }

//    public Contact(string name, string phone, string email)
//    {
//        Name = name;
//        Phone = phone;
//        Email = email;
//    }

//    public override string ToString() => $"{Name} - {Phone} - {Email}";
//}





//38 Задание

//using System;

//class Program
//{
//    private static char[,] board = new char[3, 3];
//    private static char currentPlayer = 'X';

//    static void Main()
//    {
//        InitializeBoard();
//        bool gameOver = false;

//        while (!gameOver)
//        {
//            PrintBoard();
//            Console.WriteLine($"Ход игрока {currentPlayer}");
//            Console.Write("Введите номер строки (0-2): ");
//            int row = int.Parse(Console.ReadLine());
//            Console.Write("Введите номер столбца (0-2): ");
//            int col = int.Parse(Console.ReadLine());

//            if (IsValidMove(row, col))
//            {
//                board[row, col] = currentPlayer;
//                if (CheckWin())
//                {
//                    PrintBoard();
//                    Console.WriteLine($"Игрок {currentPlayer} выиграл!");
//                    gameOver = true;
//                }
//                else if (IsBoardFull())
//                {
//                    PrintBoard();
//                    Console.WriteLine("Ничья!");
//                    gameOver = true;
//                }
//                else
//                {
//                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный ход, попробуйте снова.");
//            }
//        }
//    }

//    static void InitializeBoard()
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                board[i, j] = ' ';
//            }
//        }
//    }

//    static void PrintBoard()
//    {
//        Console.Clear();
//        Console.WriteLine("  0 1 2");
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write(i + " ");
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(board[i, j]);
//                if (j < 2) Console.Write("|");
//            }
//            Console.WriteLine();
//            if (i < 2) Console.WriteLine("  -----");
//        }
//    }

//    static bool IsValidMove(int row, int col)
//    {
//        return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ';
//    }

//    static bool CheckWin()
//    {
//        // Проверка строк
//        for (int i = 0; i < 3; i++)
//        {
//            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
//                return true;
//        }

//        // Проверка столбцов
//        for (int j = 0; j < 3; j++)
//        {
//            if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
//                return true;
//        }

//        // Проверка диагоналей
//        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
//            return true;

//        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
//            return true;

//        return false;
//    }

//    static bool IsBoardFull()
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                if (board[i, j] == ' ')
//                    return false;
//            }
//        }
//        return true;
//    }
//}





//39 Задание

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Генерация случайного четырехзначного числа
//        string secretNumber = GenerateRandomNumber();
//        int attempts = 0;
//        bool correctGuess = false;

//        Console.WriteLine("Добро пожаловать в игру 'Быки и коровы'!");
//        Console.WriteLine("Попробуйте угадать четырехзначное число.");

//        while (!correctGuess)
//        {
//            Console.Write("Введите ваш вариант (четыре разные цифры): ");
//            string guess = Console.ReadLine();

//            if (IsValidGuess(guess))
//            {
//                attempts++;
//                (int bulls, int cows) = GetBullsAndCows(secretNumber, guess);

//                if (bulls == 4)
//                {
//                    correctGuess = true;
//                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
//                }
//                else
//                {
//                    Console.WriteLine($"{bulls} быков, {cows} коров.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введенное число некорректно. Попробуйте снова.");
//            }
//        }
//    }

//    static string GenerateRandomNumber()
//    {
//        Random random = new Random();
//        string number;
//        HashSet<int> usedDigits = new HashSet<int>();

//        do
//        {
//            number = "";
//            usedDigits.Clear();

//            for (int i = 0; i < 4; i++)
//            {
//                int digit;
//                do
//                {
//                    digit = random.Next(0, 10);
//                } while (usedDigits.Contains(digit));

//                usedDigits.Add(digit);
//                number += digit.ToString();
//            }
//        } while (number.Length != 4);

//        return number;
//    }

//    static bool IsValidGuess(string guess)
//    {
//        if (guess.Length != 4)
//        {
//            return false;
//        }

//        HashSet<char> uniqueDigits = new HashSet<char>();
//        foreach (char c in guess)
//        {
//            if (!char.IsDigit(c) || !uniqueDigits.Add(c))
//            {
//                return false;
//            }
//        }

//        return true;
//    }

//    static (int bulls, int cows) GetBullsAndCows(string secret, string guess)
//    {
//        int bulls = 0;
//        int cows = 0;
//        Dictionary<char, int> secretDigitCount = new Dictionary<char, int>();

//        // Подсчет быков
//        for (int i = 0; i < 4; i++)
//        {
//            if (guess[i] == secret[i])
//            {
//                bulls++;
//            }
//            else
//            {
//                if (secretDigitCount.ContainsKey(secret[i]))
//                {
//                    secretDigitCount[secret[i]]++;
//                }
//                else
//                {
//                    secretDigitCount[secret[i]] = 1;
//                }
//            }
//        }

//        // Подсчет коров
//        for (int i = 0; i < 4; i++)
//        {
//            if (guess[i] != secret[i] && secretDigitCount.ContainsKey(guess[i]))
//            {
//                cows += Math.Min(secretDigitCount[guess[i]], 1);
//            }
//        }

//        return (bulls, cows);
//    }
//}



//40 Задание

//using System;

//class Program
//{
//    private static decimal balance;
//    private static Random random = new Random();

//    static void Main()
//    {
//        // Инициализация начального баланса случайным числом от 100 до 10000
//        balance = GenerateRandomBalance();

//        bool exit = false;

//        while (!exit)
//        {
//            Console.Clear();
//            Console.WriteLine("Добро пожаловать в банкомат!");
//            Console.WriteLine("1. Внести средства");
//            Console.WriteLine("2. Снять средства");
//            Console.WriteLine("3. Просмотреть баланс");
//            Console.WriteLine("4. Выйти");
//            Console.Write("Выберите операцию (1-4): ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Deposit();
//                    break;
//                case "2":
//                    Withdraw();
//                    break;
//                case "3":
//                    ViewBalance();
//                    break;
//                case "4":
//                    exit = true;
//                    Console.WriteLine("Спасибо за использование банкомата. До свидания!");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    static decimal GenerateRandomBalance()
//    {
//        // Генерация случайного начального баланса от 100 до 10000
//        return random.Next(100, 10001) + random.Next(0, 100) / 100m;
//    }

//    static void Deposit()
//    {
//        Console.Write("Введите сумму для внесения: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Вы внесли {amount:C}. Текущий баланс: {balance:C}");
//        }
//        else
//        {
//            Console.WriteLine("Введите корректную сумму.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void Withdraw()
//    {
//        Console.Write("Введите сумму для снятия: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            if (amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Вы сняли {amount:C}. Текущий баланс: {balance:C}");
//            }
//            else
//            {
//                Console.WriteLine("Недостаточно средств для снятия.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Введите корректную сумму.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void ViewBalance()
//    {
//        Console.WriteLine($"Текущий баланс: {balance:C}");
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }
//}



//41 Задание


//using System;
//using System.Data;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // Замените путь на путь к вашему CSV-файлу
//        string filePath = "dd.csv";

//        if (File.Exists(filePath))
//        {
//            DataTable dataTable = LoadCsv(filePath);
//            PrintTable(dataTable);
//        }
//        else
//        {
//            Console.WriteLine("Файл не найден.");
//        }
//    }

//    static DataTable LoadCsv(string filePath)
//    {
//        DataTable dataTable = new DataTable();

//        using (StreamReader sr = new StreamReader(filePath))
//        {
//            string[] headers = sr.ReadLine()?.Split(',');
//            if (headers != null)
//            {
//                foreach (string header in headers)
//                {
//                    dataTable.Columns.Add(header);
//                }

//                string line;
//                while ((line = sr.ReadLine()) != null)
//                {
//                    string[] fields = line.Split(',');
//                    DataRow row = dataTable.NewRow();
//                    for (int i = 0; i < fields.Length; i++)
//                    {
//                        row[i] = fields[i];
//                    }
//                    dataTable.Rows.Add(row);
//                }
//            }
//        }

//        return dataTable;
//    }

//    static void PrintTable(DataTable table)
//    {
//        // Вывод заголовков столбцов
//        foreach (DataColumn column in table.Columns)
//        {
//            Console.Write($"{column.ColumnName,-20}");
//        }
//        Console.WriteLine();

//        // Вывод данных
//        foreach (DataRow row in table.Rows)
//        {
//            foreach (var item in row.ItemArray)
//            {
//                Console.Write($"{item,-20}");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//42 Задание

//using System;

//class Program
//{
//    static void Main()
//    {
//        const int daysInWeek = 7;
//        decimal[] temperatures = new decimal[daysInWeek];
//        decimal totalTemperature = 0m;

//        Console.WriteLine("Программа для вычисления средней температуры за неделю.");

//        for (int i = 0; i < daysInWeek; i++)
//        {
//            while (true)
//            {
//                Console.Write($"Введите температуру для дня {i + 1}: ");
//                string input = Console.ReadLine();

//                if (decimal.TryParse(input, out decimal temperature) && temperature >= -100 && temperature <= 60)
//                {
//                    temperatures[i] = temperature;
//                    totalTemperature += temperature;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Ошибка: введите корректную температуру в диапазоне от -100 до 60 градусов.");
//                }
//            }
//        }

//        decimal averageTemperature = totalTemperature / daysInWeek;
//        Console.WriteLine($"Средняя температура за неделю: {averageTemperature:F2} градусов.");
//    }
//}


// 44 Задание

//using System;
//using System.IO;

//class Program
//{
//    private static FileSystemWatcher _fileSystemWatcher;

//    static void Main(string[] args)
//    {
//        // Укажите путь к директории, которую хотите отслеживать
//        string directoryToWatch = @"C:\Users\polin\OneDrive\Рабочий стол";

//        // Создаем экземпляр FileSystemWatcher и настраиваем его
//        _fileSystemWatcher = new FileSystemWatcher
//        {
//            Path = directoryToWatch,
//            Filter = "*.txt", // Отслеживаем только текстовые файлы
//            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName
//        };

//        // Подписываемся на события изменения файла
//        _fileSystemWatcher.Changed += OnChanged;
//        _fileSystemWatcher.Created += OnChanged;
//        _fileSystemWatcher.Deleted += OnDeleted;

//        // Начинаем отслеживание
//        _fileSystemWatcher.EnableRaisingEvents = true;

//        Console.WriteLine($"Отслеживание изменений в директории: {directoryToWatch}");
//        Console.WriteLine("Нажмите [Enter], чтобы завершить программу.");
//        Console.ReadLine(); // Ожидание нажатия клавиши Enter для завершения программы
//    }

//    private static void OnChanged(object source, FileSystemEventArgs e)
//    {
//        // Создаем отметку времени для имени файла
//        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//        string backupFileName = $"{Path.GetFileNameWithoutExtension(e.FullPath)}_{timestamp}{Path.GetExtension(e.FullPath)}";
//        string backupFilePath = Path.Combine(Path.GetDirectoryName(e.FullPath), backupFileName);

//        try
//        {
//            // Сохраняем копию измененного файла
//            File.Copy(e.FullPath, backupFilePath);
//            Console.WriteLine($"Файл {e.FullPath} был изменен. Создана резервная копия: {backupFilePath}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка при сохранении копии файла: {ex.Message}");
//        }
//    }

//    private static void OnDeleted(object source, FileSystemEventArgs e)
//    {
//        Console.WriteLine($"Файл {e.FullPath} был удален.");
//    }
//}

//45 Задание


//using System;
//using System.Collections.Generic;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // Список для хранения данных о продажах
//        List<Sale> sales = new List<Sale>();

//        // Ввод данных
//        Console.WriteLine("Введите данные о продажах. Введите 'exit' для завершения ввода.");
//        while (true)
//        {
//            Console.Write("Введите название товара (или 'exit' для завершения): ");
//            string productName = Console.ReadLine();
//            if (productName.ToLower() == "exit") break;

//            Console.Write("Введите количество проданных единиц: ");
//            if (!int.TryParse(Console.ReadLine(), out int quantity))
//            {
//                Console.WriteLine("Некорректное значение количества. Попробуйте снова.");
//                continue;
//            }

//            Console.Write("Введите цену за единицу: ");
//            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
//            {
//                Console.WriteLine("Некорректное значение цены. Попробуйте снова.");
//                continue;
//            }

//            sales.Add(new Sale
//            {
//                ProductName = productName,
//                Quantity = quantity,
//                Price = price
//            });
//        }

//        // Генерация отчета
//        string report = GenerateReport(sales);

//        // Запись отчета в файл
//        string filePath = "rr.txt";
//        File.WriteAllText(filePath, report);

//        Console.WriteLine($"Отчет сохранен в файл {filePath}");
//    }

//    static string GenerateReport(List<Sale> sales)
//    {
//        var report = "Отчет по продажам\n";
//        report += "============================\n";
//        report += $"{"Название товара",-20}|{"Количество",-10} | {"Цена",-10} | {"Сумма",-10}\n";
//        report += "----------------------------\n";

//        decimal totalSales = 0;
//        foreach (var sale in sales)
//        {
//            decimal total = sale.Quantity * sale.Price;
//            totalSales += total;
//            report += $"{sale.ProductName,-20}| {sale.Quantity,-10}| {sale.Price,-10:C} | {total,-10:C}\n";
//        }

//        report += "----------------------------\n";
//        report += $"{"Итого:",-20}{""}{"",-10}{totalSales:C}\n";

//        return report;
//    }
//}

//class Sale
//{
//    public string ProductName { get; set; }
//    public int Quantity { get; set; }
//    public decimal Price { get; set; }
//}


// 46 Задание

//using System;
//using System.Collections.Generic;

//class Program
//{
//    private static Dictionary<string, bool> visitors = new Dictionary<string, bool>();

//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Учет посетителей мероприятия");
//            Console.WriteLine("1. Добавить посетителя");
//            Console.WriteLine("2. Отметить присутствие");
//            Console.WriteLine("3. Вывести список всех посетителей");
//            Console.WriteLine("4. Выход");
//            Console.Write("Выберите действие: ");

//            var input = Console.ReadLine();
//            switch (input)
//            {
//                case "1":
//                    AddVisitor();
//                    break;
//                case "2":
//                    MarkAttendance();
//                    break;
//                case "3":
//                    DisplayVisitors();
//                    break;
//                case "4":
//                    return;
//                default:
//                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    private static void AddVisitor()
//    {
//        Console.Write("Введите Фамилию и Имя посетителя: ");
//        var name = Console.ReadLine();

//        if (!string.IsNullOrWhiteSpace(name) && !visitors.ContainsKey(name))
//        {
//            visitors[name] = false; // по умолчанию присутствие не отмечено
//            Console.WriteLine("Посетитель добавлен.");
//        }
//        else
//        {
//            Console.WriteLine("Посетитель уже существует или имя некорректное.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    private static void MarkAttendance()
//    {
//        Console.Write("Введите Фамилию и Имя посетителя: ");
//        var name = Console.ReadLine();

//        if (visitors.ContainsKey(name))
//        {
//            visitors[name] = true;
//            Console.WriteLine("Присутствие отмечено.");
//        }
//        else
//        {
//            Console.WriteLine("Посетитель не найден.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    private static void DisplayVisitors()
//    {
//        Console.WriteLine("Список всех посетителей:");
//        foreach (var visitor in visitors)
//        {
//            var status = visitor.Value ? "Присутствует" : "Не присутствует";
//            Console.WriteLine($"{visitor.Key} - {status}");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }
//}


// 47 Задание

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//class Program
//{
//    static List<TaskItem> tasks = new List<TaskItem>();

//    static async Task Main(string[] args)
//    {
//        Console.WriteLine("Добро пожаловать!");
//        while (true)
//        {
//            Console.WriteLine("\nВыберите действие:");
//            Console.WriteLine("1. Добавить задачу");
//            Console.WriteLine("2. Показать задачи");
//            Console.WriteLine("3. Выход");

//            var choice = Console.ReadLine();
//            switch (choice)
//            {
//                case "1":
//                    AddTask();
//                    break;
//                case "2":
//                    ShowTasks();
//                    break;
//                case "3":
//                    Console.WriteLine("Выход...");
//                    return;
//                default:
//                    Console.WriteLine("Некорректный выбор.");
//                    break;
//            }

//            // Запуск задачи уведомления в фоновом режиме
//            await NotifyTasksAsync();
//        }
//    }

//    static void AddTask()
//    {
//        Console.Write("Введите описание задачи: ");
//        var description = Console.ReadLine();

//        Console.Write("Введите время выполнения задачи (в формате чч:мм:сс): ");
//        var timeString = Console.ReadLine();

//        if (TimeSpan.TryParse(timeString, out var timeOfDay))
//        {
//            var now = DateTime.Now;
//            var dueTime = DateTime.Today.Add(timeOfDay);
//            if (dueTime < now)
//                dueTime = dueTime.AddDays(1); // Если время уже прошло, устанавливаем на следующий день

//            var task = new TaskItem
//            {
//                Description = description,
//                DueTime = dueTime
//            };
//            tasks.Add(task);

//            Console.WriteLine("Задача добавлена.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный формат времени.");
//        }
//    }

//    static void ShowTasks()
//    {
//        Console.WriteLine("Список задач:");
//        foreach (var task in tasks.OrderBy(t => t.DueTime))
//        {
//            Console.WriteLine($"{task.Description} - {task.DueTime:чч:мм:сс}");
//        }
//    }

//    static async Task NotifyTasksAsync()
//    {
//        // Отдельная задача для уведомления
//        _ = Task.Run(async () =>
//        {
//            while (true)
//            {
//                var now = DateTime.Now;
//                foreach (var task in tasks.Where(t => t.DueTime <= now && !t.IsNotified))
//                {
//                    Console.WriteLine($"\nУведомление: Задача '{task.Description}' наступила в {task.DueTime:чч:мм:сс}");
//                    task.IsNotified = true;
//                }

//                await Task.Delay(1000); // Проверка каждую секунду
//            }
//        });
//    }
//}

//class TaskItem
//{
//    public string Description { get; set; }
//    public DateTime DueTime { get; set; }
//    public bool IsNotified { get; set; } = false;
//}
//48 Закдание

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SalesAnalysisApp
//{
//    // Класс для представления товара
//    public class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }

//        public Product(string name, decimal price)
//        {
//            Name = name;
//            Price = price;
//        }
//    }

//    // Класс для представления продажи
//    public class Sale
//    {
//        public Product Product { get; set; }
//        public int Quantity { get; set; }

//        public Sale(Product product, int quantity)
//        {
//            Product = product;
//            Quantity = quantity;
//        }
//    }

//    // Класс для анализа данных о продажах
//    public class SalesAnalyzer
//    {
//        private List<Sale> _sales;

//        public SalesAnalyzer(List<Sale> sales)
//        {
//            _sales = sales;
//        }

//        // Метод для вывода статистики по продажам
//        public void PrintStatistics()
//        {
//            var productSales = _sales.GroupBy(sale => sale.Product)
//                                     .Select(group => new
//                                     {
//                                         Product = group.Key,
//                                         TotalQuantity = group.Sum(sale => sale.Quantity),
//                                         TotalRevenue = group.Sum(sale => sale.Quantity * sale.Product.Price)
//                                     });

//            Console.WriteLine("Статистика продаж:");
//            foreach (var productSale in productSales)
//            {
//                Console.WriteLine($"Продукт: {productSale.Product.Name}");
//                Console.WriteLine($"Общее количество проданных товаров: {productSale.TotalQuantity}");
//                Console.WriteLine($"Общий доход: {productSale.TotalRevenue:C}");
//                Console.WriteLine();
//            }

//            decimal totalRevenue = productSales.Sum(ps => ps.TotalRevenue);
//            Console.WriteLine($"Общий доход от всех продуктов: {totalRevenue:C}");
//        }
//    }

//    // Основной класс программы
//    class Program
//    {
//        static void Main()
//        {
//            // Создаем продукты
//            var product1 = new Product("Виджет", 19.99m);
//            var product2 = new Product("Устройство", 29.99m);

//            // Создаем продажи
//            var sales = new List<Sale>
//            {
//                new Sale(product1, 3),
//                new Sale(product2, 2),
//                new Sale(product1, 1),
//                new Sale(product2, 4)
//            };

//            // Анализируем продажи
//            var analyzer = new SalesAnalyzer(sales);
//            analyzer.PrintStatistics();
//        }
//    }
//}


//49 Задание

//using System;
//using System.Threading;

//namespace HangmanGame
//{
//    struct Game
//    {
//        public string Word;
//        public char[] Stars;
//        public int WrongAttempts;
//    }

//    internal class Program
//    {
//        private static Game game;
//        private static readonly string[] HangmanStages =
//        {
//            @"
//                  |
//                  |
//                  |
//                  |
//                  |
//            ",
//            @"
//             ------
//                  |
//                  |
//                  |
//                  |
//                  |
//            ",
//            @"
//             ------
//                  |
//                  |
//                  |
//                  |
//                  |
//            ",
//            @"
//             ------
//             |    |
//             O    |
//                  |
//                  |
//                  |
//            ",
//            @"
//             ------
//             |    |
//             O    |
//             |    |
//                  |
//                  |
//            ",
//            @"
//             ------
//             |    |
//             O    |
//            /|\   |
//                  |
//                  |
//            ",
//            @"
//             ------
//             |    |
//             O    |
//            /|\   |
//            / \   |
//                  |
//            "
//        };

//        private static void Main(string[] args)
//        {
//            const int maxWrongAttempts = 6;

//            Console.Write("Введите слово: ");
//            string inputWord = Console.ReadLine().ToLower();
//            game.Word = inputWord;
//            game.Stars = new string('*', inputWord.Length).ToCharArray();
//            game.WrongAttempts = 0;

//            char guessedLetter = ' ';
//            Thread displayThread = new Thread(() =>
//            {
//                while (true)
//                {
//                    Console.Clear();
//                    Console.WriteLine(new string('-', 30));
//                    DisplayHangman(game.WrongAttempts);
//                    Console.WriteLine("Загаданное слово: " + string.Join("", game.Stars));
//                    Console.WriteLine(new string('-', 30));
//                    Console.WriteLine("Количество попыток: {0}, У Вас еще осталось: {1}",
//                        game.WrongAttempts, maxWrongAttempts - game.WrongAttempts);

//                    if (game.Word.Equals(string.Join("", game.Stars)))
//                    {
//                        Console.WriteLine("Поздравляю! Вы выиграли!");
//                        return;
//                    }

//                    if (game.WrongAttempts == maxWrongAttempts)
//                    {
//                        Console.WriteLine("Вы проиграли! Загаданное слово было: " + game.Word);
//                        return;
//                    }

//                    Thread.Sleep(200);
//                }
//            });
//            displayThread.Start();

//            Thread inputThread = new Thread(() =>
//            {
//                while (true)
//                {
//                    guessedLetter = Char.ToLower(Console.ReadKey(true).KeyChar);
//                    if (!game.Word.Contains(guessedLetter))
//                    {
//                        game.WrongAttempts++;
//                    }
//                    else
//                    {
//                        UpdateWord(guessedLetter);
//                    }
//                }
//            });
//            inputThread.IsBackground = true;
//            inputThread.Start();
//            Console.ReadKey(true);
//        }

//        static void UpdateWord(char letter)
//        {
//            for (int i = 0; i < game.Word.Length; i++)
//            {
//                if (game.Word[i] == letter)
//                {
//                    game.Stars[i] = letter;
//                }
//            }
//        }

//        static void DisplayHangman(int wrongAttempts)
//        {
//            if (wrongAttempts >= 0 && wrongAttempts < HangmanStages.Length)
//            {
//                Console.WriteLine(HangmanStages[wrongAttempts]);
//            }
//        }
//    }
//}


//50 Задание

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SurveyApp
//{
//    // Модели данных

//    // Класс, представляющий опрос
//    public class Survey
//    {
//        public string Title { get; set; } // Заголовок опроса
//        public List<Question> Questions { get; set; } = new List<Question>(); // Список вопросов
//    }

//    // Класс, представляющий вопрос
//    public class Question
//    {
//        public string Text { get; set; } // Текст вопроса
//        public List<AnswerOption> AnswerOptions { get; set; } = new List<AnswerOption>(); // Варианты ответов
//    }

//    // Класс, представляющий вариант ответа
//    public class AnswerOption
//    {
//        public string OptionText { get; set; } // Текст варианта ответа
//        public int Count { get; set; } // Количество голосов
//    }

//    // Сервисный класс для управления опросами
//    public class SurveyService
//    {
//        private List<Survey> surveys = new List<Survey>(); // Список опросов

//        // Создание нового опроса
//        public Survey CreateSurvey(string title)
//        {
//            var survey = new Survey { Title = title };
//            surveys.Add(survey);
//            return survey;
//        }

//        // Добавление вопроса в опрос
//        public void AddQuestion(Survey survey, string questionText, List<string> options)
//        {
//            var question = new Question { Text = questionText };
//            question.AnswerOptions.AddRange(options.Select(option => new AnswerOption { OptionText = option, Count = 0 }));
//            survey.Questions.Add(question);
//        }

//        // Добавление ответа к вопросу
//        public void AddAnswer(Survey survey, string questionText, string answerText)
//        {
//            var question = survey.Questions.FirstOrDefault(q => q.Text == questionText);
//            var answerOption = question?.AnswerOptions.FirstOrDefault(a => a.OptionText == answerText);
//            if (answerOption != null)
//            {
//                answerOption.Count++;
//            }
//        }

//        // Вывод результатов опроса
//        public void PrintSurveyResults(Survey survey)
//        {
//            Console.WriteLine($"Опрос: {survey.Title}");
//            foreach (var question in survey.Questions)
//            {
//                Console.WriteLine($"Вопрос: {question.Text}");
//                foreach (var option in question.AnswerOptions)
//                {
//                    Console.WriteLine($"Вариант: {option.OptionText} - {option.Count} голосов");
//                }
//            }
//        }

//        // Поиск опроса по заголовку
//        public Survey FindSurveyByTitle(string title)
//        {
//            return surveys.FirstOrDefault(s => s.Title == title);
//        }
//    }

//    // Основная программа
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var surveyService = new SurveyService();

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Приложение для опросов");
//                Console.WriteLine("1. Создать опрос");
//                Console.WriteLine("2. Добавить вопрос в опрос");
//                Console.WriteLine("3. Ответить на опрос");
//                Console.WriteLine("4. Просмотреть результаты опроса");
//                Console.WriteLine("5. Выход");
//                Console.Write("Выберите опцию: ");
//                var option = Console.ReadLine();

//                switch (option)
//                {
//                    case "1":
//                        CreateSurvey(surveyService);
//                        break;
//                    case "2":
//                        AddQuestion(surveyService);
//                        break;
//                    case "3":
//                        AnswerSurvey(surveyService);
//                        break;
//                    case "4":
//                        ViewSurveyResults(surveyService);
//                        break;
//                    case "5":
//                        return;
//                    default:
//                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                        break;
//                }
//            }
//        }

//        // Создание нового опроса
//        static void CreateSurvey(SurveyService surveyService)
//        {
//            Console.Write("Введите заголовок опроса: ");
//            var title = Console.ReadLine();
//            surveyService.CreateSurvey(title);
//            Console.WriteLine("Опрос успешно создан!");
//            Console.ReadKey();
//        }

//        // Добавление вопроса в опрос
//        static void AddQuestion(SurveyService surveyService)
//        {
//            Console.Write("Введите заголовок опроса, в который хотите добавить вопрос: ");
//            var title = Console.ReadLine();
//            var survey = surveyService.FindSurveyByTitle(title);
//            if (survey == null)
//            {
//                Console.WriteLine("Опрос не найден.");
//                Console.ReadKey();
//                return;
//            }

//            Console.Write("Введите текст вопроса: ");
//            var questionText = Console.ReadLine();
//            Console.WriteLine("Введите варианты ответов (разделите варианты запятыми): ");
//            var options = Console.ReadLine().Split(',').Select(o => o.Trim()).ToList();
//            surveyService.AddQuestion(survey, questionText, options);
//            Console.WriteLine("Вопрос успешно добавлен!");
//            Console.ReadKey();
//        }

//        // Ответ на опрос
//        static void AnswerSurvey(SurveyService surveyService)
//        {
//            Console.Write("Введите заголовок опроса, на который хотите ответить: ");
//            var title = Console.ReadLine();
//            var survey = surveyService.FindSurveyByTitle(title);
//            if (survey == null)
//            {
//                Console.WriteLine("Опрос не найден.");
//                Console.ReadKey();
//                return;
//            }

//            Console.WriteLine("Доступные вопросы:");
//            for (int i = 0; i < survey.Questions.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {survey.Questions[i].Text}");
//            }

//            Console.Write("Выберите вопрос по номеру: ");
//            if (int.TryParse(Console.ReadLine(), out int questionNumber) && questionNumber > 0 && questionNumber <= survey.Questions.Count)
//            {
//                var question = survey.Questions[questionNumber - 1];
//                Console.WriteLine("Доступные варианты ответов:");
//                for (int i = 0; i < question.AnswerOptions.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. {question.AnswerOptions[i].OptionText}");
//                }

//                Console.Write("Выберите ответ по номеру: ");
//                if (int.TryParse(Console.ReadLine(), out int answerNumber) && answerNumber > 0 && answerNumber <= question.AnswerOptions.Count)
//                {
//                    var answerOption = question.AnswerOptions[answerNumber - 1];
//                    surveyService.AddAnswer(survey, question.Text, answerOption.OptionText);
//                    Console.WriteLine("Ответ успешно записан!");
//                }
//                else
//                {
//                    Console.WriteLine("Неверный номер ответа.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер вопроса.");
//            }
//            Console.ReadKey();
//        }

//        // Просмотр результатов опроса
//        static void ViewSurveyResults(SurveyService surveyService)
//        {
//            Console.Write("Введите заголовок опроса, результаты которого хотите просмотреть: ");
//            var title = Console.ReadLine();
//            var survey = surveyService.FindSurveyByTitle(title);
//            if (survey != null)
//            {
//                surveyService.PrintSurveyResults(survey);
//            }
//            else
//            {
//                Console.WriteLine("Опрос не найден.");
//            }
//            Console.ReadKey();
//        }
//    }
//}


//51 Задание

//using CsvHelper;
//using CsvHelper.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;

//public class WeatherData
//{
//    public DateTime Date { get; set; }
//    public double Temperature { get; set; }
//    public double Precipitation { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var filePath = "data.csv"; // Укажите путь к вашему CSV-файлу

//        // Считать данные из CSV-файла
//        var weatherData = ReadWeatherData(filePath);

//        // Рассчитать и вывести статистику по месяцам
//        var monthlyStats = weatherData
//            .GroupBy(data => new { data.Date.Year, data.Date.Month })
//            .Select(group => new
//            {
//                Year = group.Key.Year,
//                Month = group.Key.Month,
//                AverageTemperature = group.Average(data => data.Temperature),
//                TotalPrecipitation = group.Sum(data => data.Precipitation)
//            });

//        foreach (var stat in monthlyStats)
//        {
//            Console.WriteLine($"Year: {stat.Year}, Month: {stat.Month}");
//            Console.WriteLine($"  Average Temperature: {stat.AverageTemperature:F2} °C");
//            Console.WriteLine($"  Total Precipitation: {stat.TotalPrecipitation:F2} mm");
//            Console.WriteLine();
//        }
//    }

//    private static IEnumerable<WeatherData> ReadWeatherData(string filePath)
//    {
//        using (var reader = new StreamReader(filePath))
//        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
//        {
//            return csv.GetRecords<WeatherData>().ToList();
//        }
//    }
//}

//52 Задание 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LibraryManagement
//{
//    // Класс для представления книги
//    public class Book
//    {
//        public int Id { get; set; } // Идентификатор книги
//        public string Title { get; set; } // Заголовок книги
//        public string Author { get; set; } // Автор книги
//        public string ISBN { get; set; } // ISBN книги

//        // Переопределение метода ToString для удобного отображения информации о книге
//        public override string ToString()
//        {
//            return $"ID: {Id}, Заголовок: {Title}, Автор: {Author}, ISBN: {ISBN}";
//        }
//    }

//    // Класс для управления книгами
//    public class Library
//    {
//        private List<Book> books = new List<Book>(); // Список книг
//        private int nextId = 1; // Следующий доступный ID

//        // Метод для добавления книги
//        public void AddBook(string title, string author, string isbn)
//        {
//            books.Add(new Book
//            {
//                Id = nextId++,
//                Title = title,
//                Author = author,
//                ISBN = isbn
//            });
//            Console.WriteLine("Книга успешно добавлена.");
//        }

//        // Метод для удаления книги по ID
//        public void RemoveBook(int id)
//        {
//            var book = books.FirstOrDefault(b => b.Id == id);
//            if (book != null)
//            {
//                books.Remove(book);
//                Console.WriteLine("Книга успешно удалена.");
//            }
//            else
//            {
//                Console.WriteLine("Книга не найдена.");
//            }
//        }

//        // Метод для редактирования книги
//        public void EditBook(int id, string title, string author, string isbn)
//        {
//            var book = books.FirstOrDefault(b => b.Id == id);
//            if (book != null)
//            {
//                book.Title = title;
//                book.Author = author;
//                book.ISBN = isbn;
//                Console.WriteLine("Книга успешно обновлена.");
//            }
//            else
//            {
//                Console.WriteLine("Книга не найдена.");
//            }
//        }

//        // Метод для поиска книг по заголовку
//        public void SearchBooks(string title)
//        {
//            var result = books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
//            if (result.Any())
//            {
//                foreach (var book in result)
//                {
//                    Console.WriteLine(book);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Книги не найдены.");
//            }
//        }

//        // Метод для вывода списка всех книг
//        public void ListAllBooks()
//        {
//            if (books.Any())
//            {
//                foreach (var book in books)
//                {
//                    Console.WriteLine(book);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Нет доступных книг.");
//            }
//        }
//    }

//    // Главный класс программы
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Library library = new Library(); // Создание экземпляра библиотеки

//            while (true)
//            {
//                Console.WriteLine("\nСистема управления библиотекой");
//                Console.WriteLine("1. Добавить книгу");
//                Console.WriteLine("2. Удалить книгу");
//                Console.WriteLine("3. Редактировать книгу");
//                Console.WriteLine("4. Найти книги");
//                Console.WriteLine("5. Вывести список всех книг");
//                Console.WriteLine("6. Выйти");

//                var choice = Console.ReadLine(); // Чтение выбора пользователя
//                switch (choice)
//                {
//                    case "1":
//                        // Добавление книги
//                        Console.Write("Введите заголовок: ");
//                        string title = Console.ReadLine();
//                        Console.Write("Введите автора: ");
//                        string author = Console.ReadLine();
//                        Console.Write("Введите ISBN: ");
//                        string isbn = Console.ReadLine();
//                        library.AddBook(title, author, isbn);
//                        break;

//                    case "2":
//                        // Удаление книги
//                        Console.Write("Введите ID книги для удаления: ");
//                        if (int.TryParse(Console.ReadLine(), out int removeId))
//                        {
//                            library.RemoveBook(removeId);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Неверный ID.");
//                        }
//                        break;

//                    case "3":
//                        // Редактирование книги
//                        Console.Write("Введите ID книги для редактирования: ");
//                        if (int.TryParse(Console.ReadLine(), out int editId))
//                        {
//                            Console.Write("Введите новый заголовок: ");
//                            string newTitle = Console.ReadLine();
//                            Console.Write("Введите нового автора: ");
//                            string newAuthor = Console.ReadLine();
//                            Console.Write("Введите новый ISBN: ");
//                            string newIsbn = Console.ReadLine();
//                            library.EditBook(editId, newTitle, newAuthor, newIsbn);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Неверный ID.");
//                        }
//                        break;

//                    case "4":
//                        // Поиск книг
//                        Console.Write("Введите заголовок для поиска: ");
//                        string searchTitle = Console.ReadLine();
//                        library.SearchBooks(searchTitle);
//                        break;

//                    case "5":
//                        // Вывод списка всех книг
//                        library.ListAllBooks();
//                        break;

//                    case "6":
//                        // Выход из программы
//                        return;

//                    default:
//                        Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 6.");
//                        break;
//                }
//            }
//        }
//    }
//}


