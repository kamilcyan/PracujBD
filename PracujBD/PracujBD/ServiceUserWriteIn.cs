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

                for (int i = 1; i <= 10; i++)
                {
                    var usr = new ServiceUser
                    {
                        FirstName = firstnames[r.Next(0, firstnames.Length - 1)],
                        LastName = lastnames[r.Next(0, lastnames.Length - 1)],
                        Adress = adress[r.Next(0, adress.Length - 1)],
                        PnoneNumber = r.Next(5000000, 9999999).ToString(),
                        ExpectedSalary = (decimal)r.Next(20000, 200000),
                        Profession = professions[r.Next(0, professions.Length - 1)],
                        Experience = MakingExperience(professions[r.Next(0, professions.Length - 1)]),
                        DateOfBirth = BirthDate(),
                        Skills = AddSkills(),
                        LevelOfLanguageId = r.Next(1, 6),
                        Language = AddLanguage()
                    };
                    db.Add(usr);
                    db.SaveChanges();
                }
            }
        }
    }
}
