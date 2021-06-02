using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0ProgMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            if (Test())
            {
                Console.WriteLine("Test finished");
                Execute();
            }
                
            
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
        static bool Test()
        {
            Container container = new Container();
            StreamReader reader;
            try
            {
                reader = new StreamReader("test.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return false;
            }

            StreamWriter writer = new StreamWriter("testOut.txt");
            writer.WriteLine("Start...");

            container.In(reader);

            //Console.WriteLine("Container contains {0} elements",container.Count());
            writer.WriteLine("Container contains {0} elements", container.Count());
            container.Print(writer, "");


            writer.WriteLine("Procedural only", container.Count());
            container.Print(writer, "proc");

            container.Sort();
            writer.WriteLine("Container sorted", container.Count());
            container.Print(writer, "");




            container.Clear();
            writer.WriteLine("Cleared");
            writer.WriteLine("Container contains {0} elements", container.Count());

            writer.WriteLine("Finish");

            writer.Close();



            string[] strs1 = File.ReadAllLines("testOut.txt");
            string[] strs2 = File.ReadAllLines("testEtalon.txt");

            if(strs1.Length != strs2.Length)
            {
                Console.WriteLine("Test failed");
                return false;
            }
            for(int i = 0; i < strs1.Length; i++)
            {
                if(strs1[i] != strs2[i])
                {
                    Console.WriteLine("error at {0}", i);
                    return false;
                }
            }
            return true;
        }



        static void Execute()
        {
            Container container = new Container();
            StreamReader reader;
            try
            {
                reader = new StreamReader("in.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }

            StreamWriter writer = new StreamWriter("out.txt");
            writer.WriteLine("Start...");

            container.In(reader);

            //Console.WriteLine("Container contains {0} elements",container.Count());
            writer.WriteLine("Container contains {0} elements", container.Count());
            container.Print(writer, "");


            writer.WriteLine("Procedural only", container.Count());
            container.Print(writer, "proc");

            container.Sort();
            writer.WriteLine("Container sorted", container.Count());
            container.Print(writer, "");




            container.Clear();
            writer.WriteLine("Cleared");
            writer.WriteLine("Container contains {0} elements", container.Count());

            writer.WriteLine("Finish");

            writer.Close();
        }
    }
}
