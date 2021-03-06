using System;

#nullable disable

namespace PracujBD
{
    public class LevelOfExperienceWriteIn : ReadFiles
    {
        public void WriteInLevelOfExperience()
        {
            Random r = new Random();

            using (var db = new PracujContext())
            {
                for (int i = 0; i < levelOfExperience.Length; i++)
                {
                    var lvl = new LevelOfExperience
                    {
                        Name = levelOfExperience[i]
                    };
                    db.Add(lvl);
                    db.SaveChanges();
                }
            }
        }
    }
}
