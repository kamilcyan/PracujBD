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
                    int indexExperience = r.Next(0, professions.Length - 1);
                    var name = new ServiceUser
                    {
                        FirstName = firstnames[indexFirstNames],
                        LastName = lastnames[indexLastNames],
                        Adress = adress[indexAdress],
                        PnoneNumber = phone.ToString(),
                        ExpectedSalary = (decimal)expectedSalary,
                        Profession = professions[indexProfessions],
                        Experience = MakingExperience(professions[indexExperience]),
                    };
                    db.Add(name);
                    db.SaveChanges();
                }

            }


        }

        public string MakingExperience(string xpr)
        {
            Random r = new Random();
            Random r2 = new Random();

            int duration = r.Next(0, 1500);
            int duration2 = r.Next(0, 1500);

            if(duration > duration2)
            {
                DateTime d1 = new DateTime(2015, 1, 1 );
                string date1 = d1.AddDays(duration2).ToString("yyyy/MM/dd");
                DateTime d2 = new DateTime(2015, 1, 1 );
                string date2 = d2.AddDays(duration).ToString("yyyy/MM/dd");

                return xpr + " " + date1 + "-" + date2;
            }
            else
            {
                DateTime d1 = new DateTime(2015, 1, 1);
                string date1 = d1.AddDays(duration).ToString("yyyy/MM/dd");
                DateTime d2 = new DateTime(2015, 1, 1);
                string date2 = d2.AddDays(duration2).ToString("yyyy/MM/dd");

                return xpr + " " + date1 + "-" + date2;
            }
        }
    }
}
