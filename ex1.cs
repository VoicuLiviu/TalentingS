using System;
using System.Net.Sockets;

//EX1

public class ex1
{

    //  1.A Suma a doua numere
    public static int Sum(int x1, int x2)
    {
        int total;
        total = x1 + x2;
        return total;
    }
    
    //1.C 

    // Overloading 
    public int Suma(int a, int b)
    {
        return a + b;
    }

    public class Calculator
    {

        //calcularea sumei a trei numere
        public int Suma(int a, int b, int c)
        {
            return a + b + c;
        }

        //calcularea sumei a patru numere
        public int Suma(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        //calcularea sumei a unui număr variabil de numere
        public int Suma(params int[] numere)
        {
            int suma = 0;
            foreach (int numar in numere)
            {
                suma += numar;
            }

            return suma;
        }
    }

    public static void Main()
    {

        Console.Write("\nFunctia care caluculeaza suma a 2 numere :\n");


        //primul numar
        Console.Write("x1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        //al doilea nr
        Console.Write("x2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        // Suma numerelor :
        Console.WriteLine("\nSuma numerelor este:  {0} \n", Sum(n1, n2));


        //1.B

        static int add(int a, int b)
        {

            for (int i = 1; i <= b; i++)

            {
                a++;
            }

            return a;
        }

        Console.Write("y1: ");
        int a1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("y2: ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        int a = add(a1, b1);
        Console.Write(a);
       
        //1C
        Calculator calculator = new Calculator();

        // Exemplu pentru calculul sumei folosind operatorul '+'
        int suma1 = calculator.Suma(2, 3);
        Console.WriteLine($"Suma1: {suma1}"); // Output: Suma1: 5
        
    }
        
}
























