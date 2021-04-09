#nullable disable

using System;

namespace PracujBD
{
    public class JobOffertsWriteIn : ReadFiles
    {

        public void WriteInJobOfferts()
        {
            Random r = new Random();

            string prof = professions[r.Next(0, professions.Length - 1)];

            using (var db = new PracujContext())
            {
                for (int i = 0; i < 10000; i++)
                {
                    var job = new JobOffert
                    {
                        NiceToHave = AddNeeded(skills, 5),
                        //Requirements = AddNeeded(weRequire, 2),
                        //Post = prof,
                        //Workplace = adress[r.Next(0, adress.Length - 1)],
                        //Responsabilities = AddNeeded(responsabilities, 2),
                        //WePropose = AddNeeded(wePropose, 2),
                        //CompanyName = companyNames[r.Next(0, companyNames.Length - 1)],
                        //TypeOfContractId = r.Next(0, typesOfContract.Length - 1),
                        //LevelOfExperienceId = r.Next(0, levelOfExperience.Length - 1), 
                        //JobDescription = "We look for " + prof + ", we need you to do: " + AddNeeded(responsabilities, 0)
                    };
                    db.Add(job);
                    db.SaveChanges();
                }
            }
        }
    }
}
