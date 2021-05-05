﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0ProgMethods
{
    class Nod
    {
        public Nod()
        {

        }
        private Nod next;
        int id = 0;
        int i;
        public void In(StreamReader reader)
        {
            string content = reader.ReadLine();

            i = int.Parse(content[0].ToString());

            switch (i)
            {
                case 0: langObj = new pl_proc(id, content); break;
                case 1: langObj = new pl_op(id, content); break;
                default: break;
            }


            if (!reader.EndOfStream)
            {

                next = new Nod();
                next.id = id + 1;
                next.In(reader);
            }

        }


        private lang langObj;

        public void Print(StreamWriter writer, int filter)
        {
            if (langObj != null && i == filter)
                langObj.Print(writer);
            if (next != null)
                next.Print(writer, filter);
        }


        public int Count()
        {
            if (next == null)
            {
                return 1;
            }
            else
            {
                return next.Count() + 1;
            }


        }
    }
}
