using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0ProgMethods
{
    class lang
    {

        public lang(int newId)
        {
            id = newId;
        }

        public int id = 0;
        public int devYear;
        public int timesSearched;

        public virtual void Print(StreamWriter writer)
        {
            writer.Write("Id: {0}\tDevelopment year: {1}\tTimes searched: {2}", id, devYear, timesSearched);
        }

    }
}
