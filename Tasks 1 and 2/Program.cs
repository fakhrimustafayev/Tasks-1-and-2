using System.ComponentModel.DataAnnotations;

//Task 1
//1
for (int i = 1; i <= 6; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine(""); 
}

Console.WriteLine();
//2
for (int i = 1; i <= 6; i++)
{
    for (int j = 1; j <= 6; j++)
    {
        if (i == 1 || i == 6 || j == 1 || j == 6)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
//3
for (int i = 1; i <= 6; i++)
{
   for (int j = 1; j <= 6; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//Task 2
for (int i = 1; i <= 10; i++)
{
   for (int j = 1; j <=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
   Console.WriteLine("-----------");
}
