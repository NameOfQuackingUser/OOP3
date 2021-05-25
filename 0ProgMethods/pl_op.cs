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
            i = int.Parse(cnt[2]);
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

        public override void Multimethod(lang lang, StreamWriter writer)
        {
            lang.oopMM(writer);

        }

        public override void oopMM(StreamWriter writer)
        {
            writer.WriteLine("oop & oop");
        }
        public override void procMM(StreamWriter writer)
        {
            writer.WriteLine("oop & proc");
        }

    }
}
