using System;

//EX2

class Pangram
{
    static void Main()
    {
        string propozitie = "This might be a pangram but who knows for sure?";
        
        if (EstePangram(propozitie))
        {
            Console.WriteLine("Propoziția este o pangramă");
        }
        else
        {
            Console.WriteLine("Propoziția nu este o pangramă");
        }
    }

    static bool EstePangram(string propozitie)
    {
        // conversie caractere
        propozitie = propozitie.ToLower();
        
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!propozitie.Contains(c))
            {
                return false;
            }
        }

        return true;
    }
}