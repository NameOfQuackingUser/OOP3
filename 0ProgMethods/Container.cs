using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _0ProgMethods
{
    class Container: Program
    {
        
        public Container()
        {
            
        }

        private Nod head;

        

        public int id = 0;

        public void In(StreamReader reader)
        {

            if(head == null)
            {
                head = new Nod();
            }
            head.In(reader);
        }

        public void Clear()
        {

            head = null;
            GC.Collect(GC.MaxGeneration,GCCollectionMode.Forced);
                
        }

        public void Print(StreamWriter writer, string filter)
        {
            if(head != null)
                head.Print(writer, filter);
        }

        public int Count()
        {
            if (head != null)
                return head.Count();
            else
                return 0;
        }
        public void Sort()
        {
            try
            {
                lang[] tmp = head.ToArray();
                for (int i = 0; i < tmp.Length - 1; i++)
                    for (int j = i + 1; j < tmp.Length; j++)
                        if (Age.Compare(tmp[i], tmp[j]))
                        {
                            lang t = tmp[i];
                            tmp[i] = tmp[j];
                            tmp[j] = t;
                        }
                head = new Nod();
                head.In(tmp, 0);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }


    }
}
