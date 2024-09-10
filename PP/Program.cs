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


