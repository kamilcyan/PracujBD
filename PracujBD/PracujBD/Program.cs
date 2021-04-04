using System;
using System.IO;

namespace PracujBD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Program();
            p.WriteIn();
        }

        public void WriteIn()
        {
            string[] firstnames = System.IO.File.ReadAllLines("first-names.txt");
            string[] lastnames = System.IO.File.ReadAllLines("names.txt");
            string[] adress = System.IO.File.ReadAllLines("places.txt");
            string[] professions = System.IO.File.ReadAllLines("professions.txt");


            Random r = new Random();

            using (var db = new PracujContext())
            {
                
                for (int i = 1; i <= 10000; i++)
                {
                    int indexFirstNames = r.Next(0, firstnames.Length - 1);
                    int indexLastNames = r.Next(0, lastnames.Length - 1);
                    int indexAdress = r.Next(0, adress.Length - 1);
                    int indexProfessions = r.Next(0, professions.Length - 1);
                    int phone = r.Next(5000000, 9999999);
                    int expectedSalary = r.Next(20000, 200000);
                    var name = new ServiceUser
                    {
                        FirstName = firstnames[indexFirstNames],
                        LastName = lastnames[indexLastNames],
                        Adress = adress[indexAdress],
                        PnoneNumber = phone.ToString(),
                        ExpectedSalary = (decimal)expectedSalary,
                        Profession = professions[indexProfessions]
                    };
                    db.Add(name);
                    db.SaveChanges();
                    //db.Update(name);
                }

            }


        }
    }
}
