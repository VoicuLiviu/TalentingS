using System;


//EX6

// class Ex6
// {
//     static void Main()
//     {
//         List<string> numeElevi = new List<string>
//         {
//             "Alin", "Mark", "Iolla", "Alecs", "Mira", "Grag", "April", "Suzzane", "Christine", "Andrew" , "Alina" , "Alessia" 
//         };
//
//         // 6.a. nume ce contin litera 'a' ce apar cel putin o data ;
//         List<string> numeCuA = new List<string>();
//         foreach (string nume in numeElevi)
//         {
//             if (nume.ToLower().Contains('a'))
//             {
//                 numeCuA.Add(nume);
//             }
//         }
//         numeCuA.Sort();
//
//         Console.WriteLine("a. Numele ce contin litera 'a' (alfabetic):");
//         foreach (string nume in numeCuA)
//         {
//             Console.WriteLine(nume);
//         }
//
//         // 6.b. numele ce au cel putin 5 litere;
//         List<string> numeCuCelPutin5Litere = new List<string>();
//         foreach (string nume in numeElevi)
//         {
//             if (nume.Length >= 5)
//             {
//                 numeCuCelPutin5Litere.Add(nume);
//             }
//         }
//
//         Console.WriteLine("\nb. Numele cu cel putin 5 litere:");
//         foreach (string nume in numeCuCelPutin5Litere)
//         {
//             Console.WriteLine(nume);
//         }
//
//         // 6.c.cel mai scurt nume;
//         string numeCelMaiScurt = numeElevi[0];
//         foreach (string nume in numeElevi)
//         {
//             if (nume.Length < numeCelMaiScurt.Length)
//             {
//                 numeCelMaiScurt = nume;
//             }
//         }
//
//         Console.WriteLine("\nc. Numele cel mai scurt din lista:");
//         Console.WriteLine(numeCelMaiScurt);
//
//         // 6.d. cel mai lung nume;
//         string numeCelMaiLung = numeElevi[0];
//         foreach (string nume in numeElevi)
//         {
//             if (nume.Length > numeCelMaiLung.Length)
//             {
//                 numeCelMaiLung = nume;
//             }
//         }
//
//         Console.WriteLine("\nd. Numele cel mai lung din lista:");
//         Console.WriteLine(numeCelMaiLung);
//
//         // 6.e.de cate ori apare 'Alina' in lista data;
//         int numarAparitiiAlina = 0;
//         foreach (string nume in numeElevi)
//         {
//             if (nume.Equals("Alina")) 
//             {
//                 numarAparitiiAlina++;
//             }
//         }
//
//         Console.WriteLine("\ne. Numarul de aparitii al numelui 'Alina' in lista data:");
//         Console.WriteLine(numarAparitiiAlina);
//     }
// }