using System;

#nullable disable

namespace PracujBD
{
    public class LevelOfLanguageWriteIn
    {
        public void WriteInLevelOfLanguage()
        {
            Random r = new Random();

            using (var db = new PracujContext())
            {
                string[] levels = { "A1", "A2", "B1", "B2", "C1", "C2" };

                for (int i = 0; i < levels.Length; i++)
                {
                    int indexLevel = r.Next(0, levels.Length - 1);
                    var lvl = new LevelOfLanguage
                    {
                        Level = levels[i]
                    };
                    db.Add(lvl);
                    db.SaveChanges();
                }
            }
        }
    }
}
