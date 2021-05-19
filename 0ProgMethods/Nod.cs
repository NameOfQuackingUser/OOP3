using System;
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
        public void In(StreamReader reader)
        {
            string content = reader.ReadLine();

            int i = int.Parse(content[0].ToString());

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

        public void Print(StreamWriter writer)
        {
            if (langObj != null)
                langObj.Print(writer);
            if (next != null)
                next.Print(writer);
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
        public lang[] ToArray()
        {
            if (next == null)
                return new lang[] { langObj };
            else
            {
                lang[] tmp = next.ToArray();
                lang[] outArr = new lang[tmp.Length + 1];
                outArr[0] = langObj;
                for (int i = 1; i < outArr.Length; i++)
                    outArr[i] = tmp[i - 1];
                return outArr;
            }
        }

        public void PrintMM(StreamWriter writer)
        {
            lang[] langs = ToArray();
            for(int i = 0; i < langs.Length; i++)
                for (int j = 0; j < langs.Length; j++)
                {
                    if (i == j)
                        continue;
                    try
                    {
                        MultiMethod((pl_op)langs[i], (pl_op)langs[j], writer);
                    }
                    catch (Exception ex) { }


                    try
                    {
                        MultiMethod((pl_op)langs[i], (pl_proc)langs[j], writer);
                    }
                    catch (Exception ex) { }

                    try
                    {
                        MultiMethod((pl_proc)langs[i], (pl_proc)langs[j], writer);
                    }
                    catch (Exception ex) { }

                    try
                    {
                        MultiMethod((pl_proc)langs[i], (pl_op)langs[j], writer);
                    }
                    catch (Exception ex) { }
                }
            
        }

        void MultiMethod(pl_op op, pl_op op2, StreamWriter writer)
        {
            writer.WriteLine("oop id {0} & oop id {1}",op.id,op2.id);
        }
        void MultiMethod(pl_op op, pl_proc proc, StreamWriter writer)
        {
            writer.WriteLine("oop id {0} & proc id {1}",op.id,proc.id);
        }
        void MultiMethod(pl_proc proc, pl_op op, StreamWriter writer)
        {
            writer.WriteLine("proc id {0} & oop id {1}",proc.id,op.id);
        }
        void MultiMethod(pl_proc proc, pl_proc proc2, StreamWriter writer)
        {
            writer.WriteLine("proc id {0} & proc id {1}",proc.id, proc2.id);
        }

    }
}
