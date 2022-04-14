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
            int command;
            string name, name2;
            Component class1 = new Class("class1");
            Component class2 = new Class("class2");
            Component instance = new Instance("Instance1");
            Component instance2 = new Instance("Instance2");
            Component instance3 = new Instance("Instance3");
            tree.Add(class1);
            tree.Add(class2);
            tree.Print();
            Console.WriteLine("Желайте ли добавить что нибудь?\n 1.ClassAdd");
            command = int.Parse(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.WriteLine("Введите имя новой ветки:");
                    name= Console.ReadLine();
                    Console.WriteLine("Введите куда новой ветки:");
                    name2 = Console.ReadLine();
                    tree.Insert(name2, name);
                    break;
                default: break;
            }
            client.ClientCode(tree,class2) ;

            Console.ReadLine();
        }
    }
}
