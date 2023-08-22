// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int ConvertDecToBin(int num)
{
    int binNum = 0;
    // int i = 1;
    // while( num > 0)
    // {
    //     binNum += num % 2 * i;
    //     i *= 10;
    //     num /= 2;
    // }
    int i = 0;
    while( num > 0)
    {
        binNum += num % 2 * (int)Math.Pow(10, i);
        Console.WriteLine($"{binNum}");
        i++;
        num /= 2;
    }
    return binNum;
}

// 13
// 13 % 2 = 1 * 1 = 1; 13 / 2 = 6; i = 10
// 6 % 2 = 0 * 10 = 0; 6 / 2 = 3; i = 100
// 3 % 2 = 1 * 100 = 100; 3 / 2 = 1; i = 1000
// 1 % 2 = 1 * 1000 = 1000; 1 / 2 = 0; i = 10000
// 1 + 0 + 100 + 1000 = 1101

int num = Prompt("Input number: ");
Console.WriteLine(ConvertDecToBin(num));