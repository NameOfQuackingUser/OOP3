using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0ProgMethods
{
    class pl_proc: lang
    {

        public pl_proc(int newid, string content):base(newid)
        {
            string[] cnt = content.Split(' ');
            base.devYear = int.Parse(cnt[1]);
            isItAbstract = bool.Parse(cnt[2]);
        }
        
        private int devYear;
        private bool isItAbstract;

        public override void Print(StreamWriter writer)
        {
            base.Print(writer);
            
            writer.WriteLine("\tType: Procedural\tAbstract classes: {0}", isItAbstract);
        }

        public override void Multimethod(lang lang, StreamWriter writer)
        {
            lang.procMM(writer);

        }

        public override void oopMM(StreamWriter writer)
        {
            writer.WriteLine("proc & oop");
        }

        public override void procMM(StreamWriter writer)
        {
            writer.WriteLine("proc & proc");
        }

    }
}
