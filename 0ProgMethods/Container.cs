﻿using System;
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

        public void Print(StreamWriter writer)
        {
            if(head != null)
                head.Print(writer);
        }

        public int Count()
        {
            if (head != null)
                return head.Count();
            else
                return 0;
        }


    }
}
