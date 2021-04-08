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

        public string MakingExperience(string xpr)
        {
            Random r = new Random();

            int duration = r.Next(0, 1500);
            int duration2 = r.Next(0, 1500);

            if (duration > duration2)
            {
                DateTime d1 = new DateTime(2015, 1, 1);
                string date1 = d1.AddDays(duration2).ToString("yyyy/MM/dd");
                DateTime d2 = new DateTime(2015, 1, 1);
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

        public DateTime BirthDate()
        {
            Random r = new Random();

            int offset = r.Next(0, 7000);

            DateTime d = new DateTime(1980, 1, 1);

            return d.AddDays(offset);
        }

        string AddSkills()
        {
            Random r = new Random();
            Random r2 = new Random();

            string skill = null;

            string[] skills = System.IO.File.ReadAllLines("skills.txt");

            int iteration = r2.Next(0, 5);

            for (int i = 0; i <= iteration; i++)
            {
                int indexSkills = r.Next(0, skills.Length - 1);

                skill += skills[indexSkills] + ", ";
            }
            return skill;
        }

        string AddLanguage()
        {
            Random r = new Random();

            string[] languages = { "English", "Deutsh", "French", "Chineese", "Hindi", "Russian" };

            string lang = languages[r.Next(0, languages.Length)];

            return lang;
        }
    }
}
