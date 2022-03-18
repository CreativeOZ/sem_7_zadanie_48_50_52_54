// 54. В матрице чисел найти сумму элементов главной диагонали

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());

int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        array[i,z] = new Random().Next(0,10);
        Console.Write(array[i,z] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        if (i == z)
        sum += array[i,z];
    }
}
Console.Write(sum);

