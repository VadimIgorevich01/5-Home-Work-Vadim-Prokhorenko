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

//Tast1____________________________________
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



