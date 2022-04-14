using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Client client = new Client();
            Component tree = new Class("Tree");
            Component Class = new Class("Class1");
            Component Class2 = new Class("Class2");
            Component Class11 = new Class("Class11");
            Component Class12 = new Class("Class12");
            Component Class13 = new Class("Class13");
            Component Class21 = new Class("Class21");
            Component Class22 = new Class("Class22");
            Component Instance11 = new Instance("Instance11");
            Component Instance12 = new Instance("Instance12");
            tree.Add(Class);
            tree.Add(Class2);
            Class.Add(Class11);
            Class.Add(Class12);
            Class.Add(Class13);
            Class2.Add(Class21);
            Class2.Add(Class22);
            Class11.Add(Instance11);
            Class11.Add(Instance12);
            tree.Display(1);
            tree.Insert("Tree", "newClass");
            Console.WriteLine();
            tree.Display(1);
            Console.ReadLine();
        }
    }
}
