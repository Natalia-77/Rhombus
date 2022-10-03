// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Enter rows:");
int rows = int.Parse(Console.ReadLine());
int[] arrRow = new int[rows];
double lengthRow = arrRow.Length;
Console.WriteLine($"Lenght row:{lengthRow}");
int i, j;
int res = (int)Math.Ceiling(lengthRow / 2);
int step = res - 1;

for (j = 1; j <= res; j++)
{
    for (i = 1; i <= step; i++)
        Console.Write("1");

    for (i = 1; i <= 2 * j - 1; i++)
        Console.Write("*");

    for (i = 1; i <= step; i++)
    {
        Console.Write("2");
    }
    step--;
    Console.Write("\n");
}
step = 1;

for (j = 0; j < res - 1; j++)
{
    for (i = 1; i <= step; i++)
        Console.Write("3");

    for (i = 1; i <= 2 * (res - j - 1) - 1; i++)
        Console.Write("*");

    for (i = 1; i <= step; i++)
    {
        Console.Write("4");
    }
    step++;
    Console.Write("\n");
}

Console.ReadLine();