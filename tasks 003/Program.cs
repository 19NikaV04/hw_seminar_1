// Задача 3:

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

float [] arr = new float[size];
Random r = new Random();

for (int i = 0; i < size; i++)
{
    arr[i] = (float)r.NextDouble()*1000;
    Console.WriteLine(arr[i]);
}

Console.WriteLine();

float max = arr[0];
float min = arr[0];
for (int i = 0; i < size; i++)
{
    if (arr[i] > max)
    max = arr[i];
    if (arr[i] < min)
    min = arr[i];
}

Console.WriteLine(max);
Console.WriteLine(min);
Console.Write($"\n Рфзница между максимальным и минимальным элементов значения массива: {max-min}");

