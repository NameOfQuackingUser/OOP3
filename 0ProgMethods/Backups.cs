

//while (key != ConsoleKey.Escape)//test container
//{

//    Console.WriteLine("0 - add\n1 - count\n2 - find\n3 - pop");
//    key = Console.ReadKey().Key;
//    Console.Clear();
//    switch (key)
//    {
//        case ConsoleKey.D0:
//            container.Add(new lang());
//            Console.WriteLine("Add");
//            break;
//        case ConsoleKey.D1:
//            Console.WriteLine(container.Count());
//            break;
//        case ConsoleKey.D2:
//            Console.Write("Input id: ");
//            int f = int .Parse(Console.ReadLine());
//            Console.WriteLine("Found: {0}",container.Find(f).id);
//            break;
//        case ConsoleKey.D3:
//            Console.WriteLine("Pop: {0}", container.Pop().id);
//            break;
//        default:
//            break;
//    }
//}


//public lang Pop()//old container functions
//{
//    lang outObj = head;
//    head = head.GetNext();
//    return outObj;
//}

//public int Count()
//{
//    int c = 0;
//    c = head.ping();
//    return c;
//}

//public lang Find(int id)
//{
//    if (head == null)
//    {

//        return null;
//    }
//    else
//    {
//        return head.find(id);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace _0ProgMethods
//{
//    class Container : Program
//    {

//        public Container()
//        {

//        }

//        private Container next;

//        private lang langObj;

//        public int id = 0;

//        public void In(StreamReader reader)
//        {
//            string content = reader.ReadLine();

//            int i = int.Parse(content[0].ToString());

//            switch (i)
//            {
//                case 0: langObj = new pl_proc(id, content); break;
//                case 1: langObj = new pl_op(id, content); break;
//                default: break;
//            }


//            if (!reader.EndOfStream)
//            {

//                next = new Container();
//                next.id = id + 1;
//                next.In(reader);
//            }

//        }

//        public void Clear()
//        {

//            if (langObj != null)
//                langObj = null;
//            if (next != null)
//            {
//                next.Clear();
//                next = null;
//            }

//        }

//        public void Print()
//        {
//            if (langObj != null)
//                langObj.Print();
//            if (next != null)
//                next.Print();
//        }

//        public int Count()
//        {
//            if (next == null)
//            {
//                return 1;
//            }
//            else
//            {
//                return next.Count() + 1;
//            }


//        }


//    }
//}
