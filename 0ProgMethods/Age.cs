using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0ProgMethods
{
    class Age
    {
        public static bool Compare(lang lang1, lang lang2)
        {
            if (lang1 == null || lang2 == null)
                return false;
            return lang1.HowOldIsLang() < lang2.HowOldIsLang();
        }
    }
}
