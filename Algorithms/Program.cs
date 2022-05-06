using System.Diagnostics;
using Algorithms;
using Algorithms.Lib;

ArraysDemo();

static void ArraysDemo()
{
    int[] a1;
    a1 = new int[10];

    int[] a2 = new int[5];

    int[] a3 = new int[5] {1, 3, -2, 5, 10};

    int[] a4 = {1, 3, 2, 4, 5};

    for (int i = 0; i < a3.Length; i++)
    {
        Console.WriteLine($"{a3[i] }");
    }

    Console.WriteLine();

    foreach (var el in a4)
    {
        Console.WriteLine($"{el} ");
    }

    Console.WriteLine();

    Console.Read();
} 