int GetCheckedNumber (string info, string allowedCharacters)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (isThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
    return numberOk;
}

bool TestForNullOrEmpty(string s)
{
    bool result;
    result = s == null || s == string.Empty;
    return result;
}

bool isThereText (string typedNumber, string okChars)
{
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber [i];
        for (int j = 0; j < okChars.Length; j++)
        {
            if (characterToBeChecked == okChars [j])
            {
                checkedChars++;
                break;
            }           
        }
    }
    if (checkedChars == typedNumber.Length)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void ShowArray (int [] arr)
{
    Console.Write("Наш массив: [");
    if (arr.Length == 0)
    {
        Console.WriteLine ("Пустой массив, сэр]");
    }
    else
    {
        for (int w = 0; w < arr.Length; w++)
        {
            if (w != arr.Length - 1)
            {
                Console.Write(arr [w] + ", ");
            }
            else
            {
                Console.Write(arr [w] + "]");
            }
        }
    }
    Console.WriteLine();
}

void ShowDoubleArray (double [] array)
{
    Console.Write("Наш массив: [");
    if (array.Length == 0)
    {
        Console.WriteLine ("Пустой массив, сэр]");
    }
    else
    {
        for (int w = 0; w < array.Length; w++)
        {
            if (w != array.Length - 1)
            {
                Console.Write(array [w] + ", ");
            }
            else
            {
                Console.Write(array [w] + "]");
            }
        }
    }
    Console.WriteLine();
}

//Task1____________________________________
int length = GetCheckedNumber ("Введите количество элементов массива", "1234567890");
int [] arr1 = new int [length];
int evenFiguresCounter = 0;
for (int i = 0; i < length; i++)
{
    arr1 [i] = new Random().Next(100, 1000);
    if (arr1 [i] % 2 == 0)
    {
        evenFiguresCounter++;
    }
}
ShowArray(arr1);
Console.WriteLine($"Количество четных чисел: {evenFiguresCounter}");
// ________________________________________
//Task2____________________________________
int length2 = GetCheckedNumber ("Введите количество элементов массива", "1234567890");
int [] arr2 = new int [length2];
int  sumValueOfOddIndex= 0;
for (int i = 0; i < length2; i++)
{
    arr2 [i] = new Random().Next(-99, 100);
    if (i % 2 != 0)
    {
        sumValueOfOddIndex += arr2 [i];
    }
}
ShowArray(arr2);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumValueOfOddIndex}");
//Task3____________________________________
int length3 = GetCheckedNumber("Укажите количество переменных", "1234567890");
double [] arr3 = new double [length3];
for (int i = 0; i < length3; i++)
{
    arr3 [i] = new Random().Next(-10000, 10000) / 100.0;
}
ShowDoubleArray(arr3);
double max = arr3 [0];
double min = arr3 [0];
for (int i = 0; i < arr3.Length; i++)
{
    if (max < arr3 [i])
    {
        max = arr3 [i];
    }
    if (min > arr3 [i])
    {
        min = arr3 [i];
    }
}
double deduction = max - min;
deduction = Math.Round(deduction, 3, MidpointRounding.ToZero);
Console.WriteLine($"Максимальный элемент: {max}; Минимальный элемент: {min};\nИх разница: {deduction}");
