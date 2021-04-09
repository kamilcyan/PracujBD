using System;
using System.IO;

namespace PracujBD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var s = new ServiceUserWriteIn();
            //s.WriteInServiceUser();

            var j = new JobOffertsWriteIn();
            j.WriteInJobOfferts();

            //    var l = new LevelOfLanguageWriteIn();
            //    l.WriteInLevelOfLanguage();


            //    var t = new TypeOfContractWriteIn();
            //    t.WriteInTypeOfContract();

            //    var le = new LevelOfExperienceWriteIn();
            //    le.WriteInLevelOfExperience();
            }
        }
}
