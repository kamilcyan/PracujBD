using System;

#nullable disable

namespace PracujBD
{
    public class TypeOfContractWriteIn : ReadFiles
    {
        public void WriteInTypeOfContract()
        {
            Random r = new Random();

            using (var db = new PracujContext())
            {
                for (int i = 0; i < typesOfContract.Length; i++)
                {
                    var type = new TypeOfContract
                    {
                        Name = typesOfContract[i]
                    };
                    db.Add(type);
                    db.SaveChanges();
                }
            }
        }
    }
}
