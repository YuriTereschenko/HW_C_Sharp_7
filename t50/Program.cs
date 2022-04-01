/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Какой эллимент ищем?");
int lookingNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
bool isHere = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count++;
        if (count == lookingNumber)
        {
            System.Console.WriteLine(array[i, j]);
            isHere = true;
            break;
        }
    }
}

if (isHere == false)
{
    System.Console.WriteLine("Такого числа в массиве нет");
}
