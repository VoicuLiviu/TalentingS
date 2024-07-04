using System;

//EX7

// class Persoana
// {
//     
//     private string cnp;
//     public string Nume { get; set; }
//     public string Prenume { get; set; }
//
//     public string CNP
//     {
//         get { return cnp; }
//         set { cnp = value; }
//     }
//
//     
//     public virtual void AfiseazaDetalii()
//     {
//         Console.WriteLine($"Persoana: {Nume} {Prenume}, CNP: {CNP}");
//     }
// }
//
// class Student : Persoana
// {
//     public List<int> Note { get; set; } = new List<int>();
//
//     
//     public void AdaugaNota(int nota)
//     {
//         Note.Add(nota);
//     }
//
//     
//     public override void AfiseazaDetalii()
//     {
//         Console.WriteLine($"Student: {Nume} {Prenume}, CNP: {CNP}");
//     }
// }
//
// class Profesor : Persoana
// {
//     public string Curs { get; set; }
//
//     
//     public override void AfiseazaDetalii()
//     {
//         Console.WriteLine($"Profesor: {Nume} {Prenume}, CNP: {CNP}, Curs: {Curs}");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         Student student1 = new Student
//         {
//             Nume = "Popescu",
//             Prenume = "Ion",
//             CNP = "1234567890123"
//         };
//         student1.AdaugaNota(10);
//         student1.AdaugaNota(8);
//
//         Profesor profesor1 = new Profesor
//         {
//             Nume = "Ionescu",
//             Prenume = "Maria",
//             CNP = "9876543210987",
//             Curs = "Matematica"
//         };
//
//         
//         student1.AfiseazaDetalii();
//         profesor1.AfiseazaDetalii();
//
//         
//         Console.WriteLine("Notele studentului:");
//         foreach (var nota in student1.Note)
//         {
//             Console.WriteLine(nota);
//         }
//     }
// }