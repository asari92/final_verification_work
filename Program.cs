
string[] inputArray = { "hello", "2", "world", ":-)" };
Console.WriteLine("Нажмите 'y' если хотите ввести строки вручную.");
ConsoleKeyInfo pressed;
pressed = Console.ReadKey(true);
if (pressed.KeyChar == 'y')
{
    inputArray = GetArrayFromConsole(Prompt("Введите размер массива: "));
}
Console.WriteLine("Массив из строк, длина которых меньше 3 символов: ");
ShowArray(GetLessThanThreeSymbolArray(inputArray));

int Prompt(string message)
{
    System.Console.Write(message);
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Неверный ввод! Повторите попытку.");
        System.Console.Write(message);
    }
    return number;
}

void ShowArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

string[] GetArrayFromConsole(int arrayLength)
{
    string[] inputArray = new string[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i}ую строку: ");
        inputArray[i] = Console.ReadLine();
    }

    return inputArray;
}

string[] GetLessThanThreeSymbolArray(string[] inputArray)
{
    int inputArrayLength = inputArray.Length;
    int count = 0;

    for (int i = 0; i < inputArrayLength; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] lessThanThreeArray = new string[count];
    int j = 0;

    for (int i = 0; i < inputArrayLength; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            lessThanThreeArray[j] = inputArray[i];
            j++;
        }
    }

    return lessThanThreeArray;
}