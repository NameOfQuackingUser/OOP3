using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0ProgMethods
{
    class FunctionalLang:lang
    {
        public FunctionalLang(int newid, string content) : base(newid)
        {
            string[] cnt = content.Split(' ');
            base.devYear = int.Parse(cnt[1]);
            base.timesSearched = int.Parse(cnt[2]);
            i = int.Parse(cnt[3]);
            lazyCalc = bool.Parse(cnt[4]);
        }
        int i = 0;
        bool lazyCalc;
        
        private enum typization { strict, dynamic };

        public override void Print(StreamWriter writer)
        {
            base.Print(writer);
            typization typ = (typization)i;
            

            //Console.WriteLine("\tInheritance: {0}",inh);
            writer.WriteLine("\tType: Functional\tTypization: {0}\t'Lazy' calculations: {1}", typ,lazyCalc);
        }
    }
}
