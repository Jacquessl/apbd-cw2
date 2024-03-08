// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Modyfikacja 1");
        Console.WriteLine("Modyfikacja 2");
        Console.WriteLine("Modyfikacja 3");
        
        Console.WriteLine("Wymaganie 1: " + featureAverage(new int[]{1,2,3,4,5,6}));
        Console.WriteLine("Wymaganie 2: " + featureMax(new int[]{1,2,3,4,5,6}));
        Console.WriteLine("Wymaganie 3: " + featureMax2(new int[]{1,2,3,4,5,6}));
        
    }

    static int featureAverage(int[] tab)
    {
        int suma = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            suma += tab[i];
        }

        return suma / tab.Length;
    }

    static int featureMax(int[] tab)
    {
        int max = -1;
        for (int i = 0; i<tab.Length;i++)
        {
            if (tab[i] > max)
            {
                max = tab[i];
            }
        }

        return max;
    }
    static int featureMax2(int[] tab)
    {
        int max = -1;
        int max2 = -1;
        for (int i = 0; i<tab.Length;i++)
        {
            if (tab[i] > max)
            {
                max2 = max;
                max = tab[i];
            }
        }

        return max2;
    }
}


