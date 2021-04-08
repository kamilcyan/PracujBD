using System;
using System.Collections.Generic;
using System.Text;

namespace PracujBD
{
    public class ReadFiles
    {
        public string[] firstnames { get; set; }
        public string[] lastnames { get; set; }
        public string[] adress { get; set; }
        public string[] professions { get; set; }

        public ReadFiles()
        {
            firstnames = System.IO.File.ReadAllLines("first-names.txt");
            lastnames = System.IO.File.ReadAllLines("names.txt");
            adress = System.IO.File.ReadAllLines("places.txt");
            professions = System.IO.File.ReadAllLines("professions.txt");
        }
    }
}
