// 50. В двумерном массиве n×m заменить четные элементы на противоположные

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
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        if (array[i,z] % 2 == 0)
        array[i,z] = array[i,z] * -1;
        Console.Write(array[i,z] + " ");
    }
    Console.WriteLine();
}
