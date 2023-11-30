// Задание 1:

int size = 10;

int [] a = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
    a[i] = random.Next(1, 100);
    Console.WriteLine(a[i]);
}

Console.WriteLine();

int count = 0
for (int i = 0; i < size; i++)
{
    if (a[i] >= 20 && a[i] <= 90)
    count++;
}
Console.WriteLine();
System.Console.WriteLine(count);
