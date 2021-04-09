﻿using System;
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
        public string[] skills { get; set; }
        public string[] responsabilities { get; set; }
        public string[] wePropose { get; set; }
        public string[] weRequire { get; set; }
        public string[] companyNames { get; set; }

        public string[] levelOfExperience = { "No experience", "Beginner", "Average", "Advanced", "Master" };
        public string[] typesOfContract = { "1/8", "1/4", "Half", "Full", "Trial", "Practice" };
        public string[] languages = { "English", "Deutsh", "French", "Chineese", "Hindi", "Russian" };

        public ReadFiles()
        {
            skills = System.IO.File.ReadAllLines("skills.txt");
            firstnames = System.IO.File.ReadAllLines("first-names.txt");
            lastnames = System.IO.File.ReadAllLines("names.txt");
            adress = System.IO.File.ReadAllLines("places.txt");
            professions = System.IO.File.ReadAllLines("professions.txt");
            responsabilities = System.IO.File.ReadAllLines("responsabilities.txt");
            wePropose = System.IO.File.ReadAllLines("wePropose.txt");
            weRequire = System.IO.File.ReadAllLines("weRequire.txt");
            companyNames = System.IO.File.ReadAllLines("companyNames.txt");
        }

        protected string MakingExperience(string xpr)
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

        protected string AddLanguage()
        {
            Random r = new Random();

            string lang = languages[r.Next(0, languages.Length)];

            return lang;
        }

        protected DateTime BirthDate()
        {
            Random r = new Random();

            int offset = r.Next(0, 7000);

            DateTime d = new DateTime(1980, 1, 1);

            return d.AddDays(offset);
        }

        protected string AddNeeded(string[] table, int range)
        {
            Random r = new Random();
            Random r2 = new Random();

            string response = null;


            int iteration = r2.Next(0, range);

            for (int i = 0; i <= iteration; i++)
            {
                response += table[r.Next(0, table.Length - 1)] + ", ";
            }
            return response;
        }
    }
}
