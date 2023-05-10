using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H23_Dev_Info_TP3
{
    public class DataValidators
    {
        public bool IsValidEmail(string email)
        {
            // la chaine de caractère ne doit pas être nulle ou vide
            if(string.IsNullOrWhiteSpace(email)) 
                return false;

            // le courriel doit contenir un seul @
            if (email.IndexOf("@") != email.LastIndexOf("@"))
                return false;

            // le courriel doit contenir un point
            if (!email.Contains("."))
                return false;

            // email doit contenir au moins un point après le @
            if (email.IndexOf("@") > email.LastIndexOf("."))
                return false;

            // email doit contenir au moins deux caractères après le dernier point
            if (email.Length - email.LastIndexOf(".") < 3)
                return false;

            // email ne doit pas contenir d'espace
            if (email.Contains(" "))
                return false;

            // email ne doit pas commencer ni se terminer par un point ou un @
            if (email.StartsWith(".") || email.StartsWith("@") || email.EndsWith(".") || email.EndsWith("@"))
                return false;

            // email ne doit pas contenir de caractères
            if (email.Contains("é") || email.Contains("è") || email.Contains("à") || email.Contains("ù") || email.Contains("ç"))
                return false;

            // email doit avoir au moins un caractère avant le @
            if (email.IndexOf("@") < 1)
                return false;

            // sinon, on considère que le courriel est valide
            return true;
        }

    }
}
