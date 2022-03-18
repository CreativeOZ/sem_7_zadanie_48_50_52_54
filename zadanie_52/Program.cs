// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
for (int i = 0; i < m; i+=2)
{
    for (int z = 0; z < n; z+=2)
    {
        array[i,z] = array[i,z] * array[i,z];
    }
}
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        Console.Write(array[i,z] + " ");
    }
    Console.WriteLine();
}

