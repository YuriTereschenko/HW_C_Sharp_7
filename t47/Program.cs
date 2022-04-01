/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

System.Console.WriteLine("Введите высоту массива");
int height = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите ширину массива");
int weight = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[height, weight];

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < weight; j++)
    {
        array[i, j] = new Random().NextDouble();
    }
}

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < weight; j++)
    {
        System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
}