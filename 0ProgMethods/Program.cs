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

            Container container = new Container();

            StreamReader reader = new StreamReader("in.txt");
            StreamWriter writer = new StreamWriter("out.txt");
            writer.WriteLine("Start...");

            container.In(reader);

            //Console.WriteLine("Container contains {0} elements",container.Count());
            writer.WriteLine("Container contains {0} elements", container.Count());
            container.Print(writer);

            container.Clear();
            writer.WriteLine("Cleared");
            writer.WriteLine("Container contains {0} elements", container.Count());
            
            writer.WriteLine("Finish");

            writer.Close();
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
