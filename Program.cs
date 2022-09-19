
string[] inputArray = { "hello", "2", "world", ":-)" };

System.Console.WriteLine("Нажмите 'y' если хотите ввести строки вручную.");
ConsoleKeyInfo pressed;
pressed = Console.ReadKey(true);
if (pressed.KeyChar == 'y')
{
    int inputArrayLength = Prompt("Введите размер массива: ");
    inputArray = new string[inputArrayLength];

    for (int i = 0; i < inputArrayLength; i++)
    {
        Console.Write($"Введите {i}ую строку: ");
        inputArray[i] = Console.ReadLine();
    }
}

System.Console.WriteLine("Массив из строк, длина которых меньше 3 символов: ");
foreach (var item in GetLessThanThreeArray(inputArray))
{
    System.Console.Write($"{item} ");
}

string[] GetLessThanThreeArray(string[] inputArray)
{
    int inputArrayLength = inputArray.Length;
    int[] indexesArray = new int[inputArrayLength];
    int count = 0;

    for (int i = 0; i < inputArrayLength; i++)
    {
        if (inputArray[i].Length < 4)
        {
            count++;
            indexesArray[i] = 1;
        }
    }

    string[] lessThanThreeArray = new string[count];
    int j = 0;

    for (int i = 0; i < inputArrayLength; i++)
    {
        if (indexesArray[i] > 0)
        {
            lessThanThreeArray[j] = inputArray[i];
            j++;
        }
    }

    return lessThanThreeArray;
}

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