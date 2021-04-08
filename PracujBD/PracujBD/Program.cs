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

            //var l = new LevelOfLanguageWriteIn();
            //l.WriteInLevelOfLanguage();

            var j = new JobOffertsWriteIn();
            j.WriteInJobOfferts();
        }
    }
}
