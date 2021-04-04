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
            string[] lines = System.IO.File.ReadAllLines("first-names.txt");
            Random r = new Random();

            using (var db = new PracujContext())
            {
                var name = new ServiceUser();
                
                for (int i = 1; i <= 10000; i++)
                {
                    int index = r.Next(0, lines.Length - 1);
                    name.FirstName = lines[index];
                    db.Add(name);
                    db.SaveChanges();
                    db.Update(name);
                }

            }


        }
    }
}
