using System; 


//Ex5
            // class Program
            // {
            //     static void Main()
            //     {
            //         // Generam 6 numere aleatoare între 1 și 49:
            //         Random random = new Random();
            //         int[] numereCastigatoare = new int[6];
            //         for (int i = 0; i < 6; i++)
            //         {
            //             numereCastigatoare[i] = random.Next(1, 50);
            //         }
            //
            //         // Introduceti nr:
            //         int[] numereParticipant = new int[6];
            //         Console.WriteLine("Introduceti 6 numere intre 1 și 49:");
            //
            //         for (int i = 0; i < 6; i++)
            //         {
            //             Console.Write($"Numarul {i + 1}: ");
            //             while (!int.TryParse(Console.ReadLine(), out numereParticipant[i]) || numereParticipant[i] < 1 || numereParticipant[i] > 49)
            //            {
            //                 Console.WriteLine("Introduceti un numar valid între 1 și 49.");
            //                 Console.Write($"Numarul {i + 1}: ");
            //             }
            //         }
            //
            //         // Verificarea:
            //         int numereIdentice = 0;
            //         for (int i = 0; i < 6; i++)
            //         {
            //             if (numereCastigatoare.Contains(numereParticipant[i]))
            //             {
            //                 numereIdentice++;
            //             }
            //         }
            //
            //         // Afisarea rezultatului
            //         Console.WriteLine("\nNumerele câștigătoare sunt:");
            //         Console.WriteLine(string.Join(", ", numereCastigatoare));
            //
            //         if (numereIdentice == 6)
            //         {
            //             Console.WriteLine("Felicitari! Ati castigat!");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Nu ati castigat. Mai încercati data viitoare!");
            //         }
            //     }
            // }