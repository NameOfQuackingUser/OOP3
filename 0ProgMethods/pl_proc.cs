﻿using System;
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
            base.timesSearched = int.Parse(cnt[2]);
            isItAbstract = bool.Parse(cnt[3]);
        }
        
        private int devYear;
        private bool isItAbstract;

        public override void Print(StreamWriter writer)
        {
            base.Print(writer);
            
            writer.WriteLine("\tType: Procedural\tAbstract classes: {0}", isItAbstract);
        }
        public override string LangName()
        {
            return "proc";
        }

    }
}
