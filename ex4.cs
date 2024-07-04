using System;

//EX4

// public class ex4
// {
//     class Program
//     {
//         static void Main()
//         {
//            
//             Console.WriteLine("Introduceti un sir:");
//             string input = Console.ReadLine();
//
//             
//             Search(input);
//             
//         }
//
//         static void Search(string input)
//         {
//             Dictionary<char, int> charCount = new Dictionary<char, int>();
//             foreach (char c in input)
//             {
//                 if (charCount.ContainsKey(c))
//                 {
//                     // Incrementam contorul:
//                     charCount[c]++;
//                 }
//                 else
//                 {
//                     //adăugăm contorul setat la 1
//                     charCount.Add(c, 1);
//                 }
//          
//             }
//             Console.WriteLine("\n Numărul de apariții al caracterului:");
//             foreach (var kvp in charCount)
//             {
//                 Console.WriteLine($"Caracterul '{kvp.Key}' apare de {kvp.Value} ori.");
//             }
//         }
//     }
//     
// }
