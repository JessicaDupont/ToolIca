using System;
using System.Collections.Generic;
using System.Text;

namespace ToolIca.LoremIpsum
{
    public static class LoremIpsum
    {
        public static int GetInt() 
        {
            Random de = new Random();
            return de.Next();
        }
        
        public static int GetInt(int min, int max)
        {
            Random de = new Random();
            return de.Next(min, max);
        }

        public static IEnumerable<int> GetInt(int nb) 
        {
            Random de = new Random();
            List<int> result = new List<int>();
            for (int i = 0; i < nb; i++)
            {
                result.Add(GetInt());
            }
            return result;
        }
        
        public static IEnumerable<int> GetInt(int nb, int min, int max) 
        {
            Random de = new Random();
            List<int> result = new List<int>();
            for (int i = 0; i < nb; i++)
            {
                result.Add(GetInt(min, max));
            }
            return result;
        }

        public static string GetString(int nb, bool lettres = true, bool chiffres = true, bool speciaux = true) 
        {
            string propositions = "";
            if (lettres) { propositions += "azertyuiopqsdfghjklmwxcvbn";  }
            if (chiffres) { propositions += "0123456789";  }
            if (speciaux) { propositions += " . !?";  }
            Random de = new Random();
            string result = "";
            for (int i = 0; i < nb; i++)
            {
                int lettre = de.Next(0,propositions.Length);
                result += propositions.Substring(lettre, 1);
            }
            return result;
        }

        public static string GetString(int min, int max, bool lettres = true, bool chiffres = true, bool speciaux = true) 
        {
            Random de = new Random();
            return GetString(de.Next(min, max), lettres, chiffres, speciaux);
        }
        
        public static string GetEmail()
        {
            return GetString(5, 15, true, true, false) 
                + "@" + GetString(3, 6, true, true, false) 
                + "." + GetString(2, 4, true, false, false);
        }
        
        public static string GetParagraphe()
        {
            return GetString(100, 500) + "\n";
        }

        public static string GetListe(List<string> liste)
        {
            Random de = new Random();
            return liste[de.Next(liste.Count)];
        }

        public static DateTime GetDate(int min, int max)
        {
            Random de = new Random();
            DateTime result = new DateTime(
                de.Next(min, max),
                de.Next(1,12),
                de.Next(1,28),
                de.Next(1,24),
                de.Next(1,59),
                0);
            return result;
        }

        public static DateTime GetHeureMinutes(int min, int max, int precision = 1)
        {
            Random de = new Random();
            DateTime result = new DateTime(
                1,
                1,
                1,
                de.Next(min, max),
                de.Next(60/precision)*precision,
                0);
            return result;
        }

        public static TimeSpan GetDureeJours(int min, int max)
        {
            Random de = new Random();
            TimeSpan result = new TimeSpan(de.Next(min, max) * TimeSpan.TicksPerDay);
            return result;
        }

        public static TimeSpan GetDureeMinutes(int min, int max)
        {
            Random de = new Random();
            TimeSpan result = new TimeSpan(de.Next(min, max)*TimeSpan.TicksPerMinute);
            return result;
        }

    }
}
