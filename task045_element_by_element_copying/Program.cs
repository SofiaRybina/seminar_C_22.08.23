// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = {3, 5, 6, 8};
Console.WriteLine("{0}", string.Join(" ",array));

int[] copyArray = CopyArr(array);
copyArray[0] = 7;
Console.WriteLine("{0}", string.Join(" ",copyArray));

int[] CopyArr(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}


