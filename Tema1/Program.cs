using System;
using System.Security.Claims;

namespace Tema1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materie algebra = new ("Algebra", "2:00");
            Materie geometrie = new ("Geometrie", "3:00");
            Materie asc = new ("Arhitectura Sistemelor de Calculatoare", "2:00");
            Materie pa = new ("Programarea Algoritmilor", "2:00");

            List<Materie> materiiAnne = new List<Materie> { algebra, asc, pa};
            List<Materie> materiiAlex = new List<Materie> { geometrie, asc, pa };

            Student student1 = new ("Scaunasu", "Anne-Marie", "15.04.2002", materiiAnne);
            Student student2 = new ("Guleama", "Dan Alexandru", "17.12.2001", materiiAlex);

            student1.Afisare();
            student2.Afisare();

            // Console.WriteLine("Apasati orice tasta pentru a inchide consola.");
            // Console.ReadKey();
        }
        /*
         * Creati o clasa Student cu nume, prenume, etc si o alta clasa Materie cu titlu, durata(string).
         * Clasa student o sa aibe o Lista de materii: public List<Materie> Materii.
         * Faceti o lista de studenti cu cateva materii si afisati-le.
         */

        class Materie
        {
            private string titlu, durata;

            public Materie() {
                this.titlu = "";
                this.durata = "0:00";
            }

            public Materie(string titlu, string durata = "0:00")
            {
                this.titlu = titlu;
                this.durata = durata;
            }

            public void Afisare()
            {
                Console.WriteLine("Materie:\nTitlu: " + titlu + "\nDurata: " + durata);
            }
        }

        class Student
        {
            private string nume, prenume, data_nastere;
            private List<Materie> materii;

            public Student()
            {
                nume = "";
                prenume = "";
                data_nastere = "";
                materii = new List<Materie>();
            }

            public Student(string nume, string prenume, string data_nastere, List<Materie> materii)
            {
                this.nume = nume;
                this.prenume = prenume;
                this.data_nastere = data_nastere;
                this.materii = materii;
            }

            public void Afisare()
            {
                Console.WriteLine("Student:\nNume: " + nume + "\nPrenume: " + prenume + "\nData de nastere: " + data_nastere);
                foreach (var materie in materii)
                {
                    materie.Afisare();
                }
            }
        }

    }
}
