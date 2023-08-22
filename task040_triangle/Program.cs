// Задача 40: Напишите программу, 
// которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

bool CheckIsExistTriangle(int a, int b, int c)
{
    if(c + b > a && a + c > b && a + b > c) return true;
    else return false;
}

int a = Prompt("Input A: ");
int b = Prompt("Input B: ");
int c = Prompt("Input C: ");
Console.WriteLine();

bool result = CheckIsExistTriangle(a, b, c);
Console.WriteLine(result? "triangle exist": "triangle not exist");
