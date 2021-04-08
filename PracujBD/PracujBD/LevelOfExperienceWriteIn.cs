using System;

#nullable disable

namespace PracujBD
{
    public class LevelOfExperienceWriteIn
    {
        public void WriteInLevelOfExperience()
        {
            Random r = new Random();

            using (var db = new PracujContext())
            {
                string[] levels = { "No experience", "Beginner", "Average", "Advanced", "Master" };

                for (int i = 0; i < levels.Length; i++)
                {
                    int indexLevel = r.Next(0, levels.Length - 1);
                    var lvl = new LevelOfExperience
                    {
                        Name = levels[i]
                    };
                    db.Add(lvl);
                    db.SaveChanges();
                }
            }
        }
    }
}
