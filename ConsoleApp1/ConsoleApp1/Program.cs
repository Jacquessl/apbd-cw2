﻿// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Modyfikacja 1");
        Console.WriteLine("Modyfikacja 2");
        Console.WriteLine("Modyfikacja 3");
        
        Console.WriteLine("Wymaganie 1: " + featureAverage(new int[]{1,2,3,4,5,6}));
        
    }

    static int featureAverage(int[] tab)
    {
        int sum = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            sum += tab[i];
        }

        return sum / tab.Length;
    }
}


