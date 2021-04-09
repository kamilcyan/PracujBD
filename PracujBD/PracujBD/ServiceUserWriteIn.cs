using System;

namespace PracujBD
{
    public class ServiceUserWriteIn : ReadFiles
    {
        

        public void WriteInServiceUser()
        {


            Random r = new Random();

            using (var db = new PracujContext())
            {

                for (int i = 1; i <= 10000; i++)
                {
                    int expectedSalafyPriorRound = r.Next(20000, 200000);
                    var usr = new ServiceUser
                    {
                        FirstName = firstnames[r.Next(0, firstnames.Length - 1)],
                        LastName = lastnames[r.Next(0, lastnames.Length - 1)],
                        Adress = adress[r.Next(0, adress.Length - 1)],
                        PnoneNumber = r.Next(5000000, 9999999).ToString(),
                        ExpectedSalary = (decimal)(Math.Round(expectedSalafyPriorRound / 100d, 0) * 100),
                        Profession = professions[r.Next(0, professions.Length - 1)],
                        Experience = MakingExperience(professions[r.Next(0, professions.Length - 1)]),
                        DateOfBirth = BirthDate(),
                        Skills = AddNeeded(skills, 3),
                        LevelOfLanguageId = r.Next(1, 6),
                        RecomendedOffertId = r.Next(1, 10000),
                        SavedOffertId = r.Next(1, 10000),
                        MyApplicationId = r.Next(1, 10000),
                        Language = AddLanguage()
                    };
                    db.Add(usr);
                    db.SaveChanges();
                }
            }
        }
    }
}
