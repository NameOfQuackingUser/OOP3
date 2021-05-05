using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0ProgMethods
{
    class pl_op: lang
    {

        public pl_op(int newid,string content):base(newid)
        {
            string[] cnt = content.Split(' ');
            base.devYear = int.Parse(cnt[1]);
            base.timesSearched = int.Parse(cnt[2]);
            i = int.Parse(cnt[3]);
        }
        int i = 0;
        
        private int devYear;
        private enum inheritance {SINGLE, MULTIPLE, INTERFACE };

        public override void Print(StreamWriter writer)
        {
            base.Print(writer);
            inheritance inh = 0;
            switch (i)
            {
                case 0: inh = inheritance.SINGLE; break;
                case 1: inh = inheritance.MULTIPLE; break;
                case 2: inh = inheritance.INTERFACE; break;
                default:break;
            }

            //Console.WriteLine("\tInheritance: {0}",inh);
            writer.WriteLine("\tType: Object-oriented\tInheritance: {0}", inh);
        }
    }
}
