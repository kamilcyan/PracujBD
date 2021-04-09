#nullable disable

using System;

namespace PracujBD
{
    public class JobOffertsWriteIn : ReadFiles
    {

        public void WriteInJobOfferts()
        {
            Random r = new Random();

            using (var db = new PracujContext())
            {

                for (int i = 1; i <= 2; i++)
                {
                    var job = new JobOffert
                    {
                        NiceToHave = AddNeeded(skills, 5),
                        Requirements = AddNeeded(weRequire, 2),
                        Post = professions[r.Next(0, professions.Length - 1)],
                        Workplace = adress[r.Next(0, adress.Length - 1)],
                        Responsabilities = AddNeeded(responsabilities, 2),
                        WePropose = AddNeeded(wePropose, 2)                        
                    };
                    db.Add(job);
                    db.SaveChanges();
                }
            }
        }
    }
}
