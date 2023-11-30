// Задание 2:

int size = 10;

int [] a = new int[size];
Random random = new Random();

int count = 0
for (int i = 0; i < size; i++)
{
    a[i] = random.Next(1, 100);
    Console.WriteLine(a[i]);

    if (a[i] % 2 == 0)
    count++;
}
Console.WriteLine();
System.Console.WriteLine(count);

