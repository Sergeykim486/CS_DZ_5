// ═══════════════════════════════ Главное меню и основные функции ═══════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 34: Сколько четных чисел в массиве                               ",
    "  ЗАДАЧА 36: Сумма всех нечетных позиций массива                          ",
    "  ЗАДАЧА 38: Разница между минимальным и максимальным значением массива   ",
    "  ЗАДАЧА HARD STAT: Массив целых чисел                                    ",
    "  ВЫХОД ИЗ ПРОГРАММЫ                                                      "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
void menu() // Функция выводит главное меню на экран консоли
{
    int CurrentLine = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.          │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта            │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}
int GetNum() // Запрос на ввод целого числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}
string GetString() // Запрос на ввод строки
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите текст... ");
    string result1 = Convert.ToString(Console.ReadLine());
    return result1;
}
double GetDouble() // Запрос на ввод Вещественного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    double result1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    return result1;
}
decimal GetRNum() // Запрос на ввод целого или дробного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    decimal result1 = Convert.ToDecimal(Console.ReadLine().Replace('.', ','));
    return result1;
}
void ErrorCatch() // Функция обрабатывает ошибку, выдает сообщение и запускает программу с начала
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}
void pause() // Функция паузы, для чтения результатов
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}
void ext() // Функция задает пользователю вопрос хочет ли он выйти из программы и закрывает ее если ответ да
{
AskAgayn:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("" +
    "  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗\n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║\n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}
int[] FillArrayRandom(int[] array1, int x, int y) // Заполнение массива [array1] случайными числами в диапазоне, от [x] до [y]
{
    for (int i = 0; i < array1.Length; i++)
    {
    Retry:
        int TempNum = new Random().Next(x, y);
        // Чтобы не было в массиве двух одинаковых чисел
        for (int i1 = 0; i1 < array1.Length; i1++)
        {
            if (TempNum == array1[i1]) goto Retry;
        }
        array1[i] = TempNum;
    }
    return (array1);
}
void ShowArray(int[] array1) // Вывести на экран массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i != array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.WriteLine($"{array1[i]}.\n");
    }
}


// ═══════════════════════════════ Задачи для выполнения ═══════════════════════════════

// 1 Задача //
int EvensInArray(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0) result++;
    }
    return (result);
}

// 2 Задача //
int SumNoEvenPosInArray(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i % 2 != 0) result = result + array1[i];
    }
    return (result);
}

// 3 Задача //
double[] FillRealArrayRandom(double[] array1, double x, double y, int ac) // Заполнение массива [array1] случайными вещественными числами в диапазоне, от [x] до [y]
{
    for (int i = 0; i < array1.Length; i++)
    {
    agayn:
        double TemnpNum2 = Math.Round(x + new Random().NextDouble() * (y - x), ac);
        for (int i1 = 0; i1 < array1.Length; i1++)
        {
            if (array1[i1] == TemnpNum2) goto agayn;
        }
        array1[i] = TemnpNum2;
    }
    return (array1);
}
void ShowRealArray(double[] array1) // Вывести на экран вещественный массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i != array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.WriteLine($"{array1[i]}.\n");
    }
}
double[] RealArrayMin(double[] array1) // double минимальное число массива
{
    int min = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < array1[min]) min = i;
    }
    double[] result = new double[2];
    result[0] = min;
    result[1] = array1[min];
    return (result);
    // result[0] - индекс минимального числа массива
    // result[1] - значение минимального числа массива
}
double[] RealArrayMax(double[] array1) // int max
{
    int max = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > array1[max]) max = i;
    }
    double[] result = new double[2];
    result[0] = max;
    result[1] = array1[max];
    return (result);
    // result[0] - индекс максимального числа массива
    // result[1] - значение максимального числа массива
}

// 4 Задача //
int[] ArrayMin(int[] array1) // int min
{
    int min = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < array1[min]) min = i;
    }
    int[] result = new int[2];
    result[0] = min;
    result[1] = array1[min];
    return (result);
}
int[] ArrayMax(int[] array1) // int max
{
    int max = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > array1[max]) max = i;
    }
    int[] result = new int[2];
    result[0] = max;
    result[1] = array1[max];
    return (result);
}
int[] arraySort(int[] array1, int parameter) // Сортировка массива parameter=1 по возрастанию parameter=0 по убыванию
{
    int temp = 0;
    for (int i = 0; i < array1.Length - 1; i++)
    {
        for (int i1 = i; i1 < array1.Length; i1++)
        {
            if (parameter == 1)
            {
                if (array1[i] > array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
            else
            {
                if (array1[i] < array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
        }
    }
    return (array1);
}
int ArrayAverage(int[] array1) // Среднее арифметическое элементов массива
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        result = result + array1[i];
    }
    result = result / array1.Length;
    return (result);
}
int ArrayMedian(int[] array1)
{
    int result = 0;
    double half = Convert.ToDouble(array1.Length % 2);
    if (half == 0)
    {
        int num2 = array1.Length;
        int num1 = num2 - 1;
        result = (array1[num1] + array1[num2]) / 2;
    }
    else result = array1[array1.Length / 2];
    return (result);
}

// ═════════════════════════════════════════════════════════════════════════════════════════════


// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════

// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        // Здесь объявляются функции которые программа выполнит при выборе того или иного пункта меню
        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Задайте длину массива...");
                int n = GetNum();
                int[] array1 = new int[n];
                FillArrayRandom(array1, 100, 1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                "СГЕНЕРИРОВАННЫЙ МАССИВ:\n");
                ShowArray(array1);
                Console.Write($"СОДЕРЖИТ {EvensInArray(array1)} ЧЕТНЫХ ЧИСЕЛ.\n" +
                "═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 2:
                Console.Clear();
                Console.WriteLine("Задайте длину массива...");
                int n1 = GetNum();
                int[] array2 = new int[n1];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задайте диапазон генератора случайных чисел...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Укажите начало диапазона...");
                int x = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int y = GetNum();
                FillArrayRandom(array2, x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                "СУММА ВСЕХ НЕЧЕТНЫХ ПОЗИЦИЙ МАССИВА:\n");
                ShowArray(array2);
                Console.Write($"РАВНА {SumNoEvenPosInArray(array2)} ЧЕТНЫХ ЧИСЕЛ.\n" +
                "═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 3:
                Console.Clear();
                Console.WriteLine("Задайте длину массива...");
                int n2 = GetNum();
                double[] array3 = new double[n2];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задайте диапазон генератора случайных чисел...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Укажите начало диапазона...");
                double RGenMin1 = GetDouble();
                Console.WriteLine("Укажите конец диапазона...");
                double RGenMax1 = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задайте количество цифр после запятой для массива...");
                int Accuracy = GetNum();
                FillRealArrayRandom(array3, RGenMin1, RGenMax1, Accuracy);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"РАЗНИЦА МЕЖДУ МИНИМАЛЬНЫМ ({RealArrayMin(array3)[1]}) И МАКСИМАЛЬНЫМ ({RealArrayMax(array3)[1]}), ЗНАЧЕНИЯМИ МАССИВА:\n");
                ShowRealArray(array3);
                Console.Write($"РАВНА {RealArrayMax(array3)[1] - RealArrayMin(array3)[1]}.\n" +
                "═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 4:
                Console.Clear();
                agayn1:
                Console.WriteLine("Задайте длину массива...");
                int n3 = GetNum();
                int[] array4 = new int[n3];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задайте диапазон генератора случайных чисел...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Укажите начало диапазона...");
                int x3 = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int y3 = GetNum();
                int nums11 = y3 - x3;
                if (nums11 <= n3)
                {
                    Console.WriteLine("В указанном диапазоне меньше чисел чем длина массива!");
                    goto agayn1;
                }
                FillArrayRandom(array4, x3, y3);
                int[] min = ArrayMin(array4);
                int[] max = ArrayMax(array4);
                //int[] TempArray = arraySort(array4, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                "СГЕНЕРИРОВАН МАССИВ:\n");
                ShowArray(array4);
                Console.Write("\n" +
                $"МИНИМАЛЬНОЕ ЗНАЧЕНИЕ МАССИВА РАВНО {min[1]}, С ИНДЕКСОМ {min[0]}\n" +
                $"МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ МАССИВА РАВНО {max[1]}, С ИНДЕКСОМ {max[0]}\n" +
                $"СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ ВСЕХ ЭЛЕМЕНТОВ МАССИВА РАВНО {ArrayAverage(array4)}\n" +
                $"МЕДИАННАЯ ВЕЛИЧИНА МАССИВА РАВНА {ArrayMedian(arraySort(array4, 1))}\n" +
                "═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 5:
                ext();
                goto restart;
        }
    }
    else goto restart;
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}