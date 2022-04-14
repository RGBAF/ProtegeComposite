using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Program
    {
        public static void Info()
        {
            Console.WriteLine("/help - Выводит подробную информацию обо всех командах;");
            Console.WriteLine("/back - Возвращает обратно к онтологии;");
            Console.WriteLine("/exit - Закрыть консоль;");
            Console.WriteLine("/addClass - Добавление класса;");
            Console.WriteLine("/addInstance - Добавление инстанции");
            Console.WriteLine("/createSlot - Создание слота");
            Console.WriteLine("/makeQuery - Сделать запрос");
        }
        static void Main(string[] args)
        {

            
            Component root = new Class("");
            Class tree = new Class("Tree");
            string command;
            root.Add(tree);
            string name;
            Console.WriteLine("Введите назавание онтологии:");
            name= Console.ReadLine();
            root.Insert("Tree", name);
            Console.WriteLine("Онтология создана");
            tree.Display(1);
            while (true)
            {
                Console.WriteLine("Введите команду(/help -информация о коммандах): ");
                command = Console.ReadLine();
                Console.Clear();
                if (command == "/help")
                {
                    Info();
                }
                else if (command == "/back")
                {
                    tree.Display(1);
                }
                else if(command == "/exit")
                {
                    Environment.Exit(0);
                }
                else if(command == "/addClass")
                {
                    
                    Console.WriteLine("Введите название нового класса: ");
                    string newNameClass = Console.ReadLine();
                    Console.WriteLine("Введите класс в который нужно добавить " + newNameClass);
                    name = Console.ReadLine();
                    root.Insert(name, newNameClass);
                    Console.WriteLine();
                    tree.Display(1);
                }
                else if(command == "/addInstance")
                {
                    Console.WriteLine("В разработке...");
                }
                else if (command == "/createSlot")
                {
                    Console.WriteLine("В разработке...");
                    Console.WriteLine("Введите название слота: ");
                    string slotName = Console.ReadLine();
                    tree.createSlot(tree, slotName);
                    Console.WriteLine("Слот " + slotName + " создан!" );
                }
                else if (command == "/makeQuery")
                {
                    Console.WriteLine("В разработке...");
                }
                else if (command == "/printSlots")
                {
                    Console.WriteLine("В разработке...");
                }
            }
            /* Component Class = new Class("Class1");
             Component Class2 = new Class("Class2");
             Component Class11 = new Class("Class11");
             Component Class12 = new Class("Class12");
             Component Class13 = new Class("Class13");
             Component Class21 = new Class("Class21");
             Component Class22 = new Class("Class22");
             Component Instance11 = new Instance("Instance11");
             Component Instance12 = new Instance("Instance12");
             root.Add(tree);
             tree.Add(Class);
             tree.Add(Class2);
             Class.Add(Class11);
             Class.Add(Class12);
             Class.Add(Class13);
             Class2.Add(Class21);
             Class2.Add(Class22);
             Class11.Add(Instance11);
             Class11.Add(Instance12);
             root.Display(1);
             root.Insert("ROOT: ", "TREE");
             Console.WriteLine();
             tree.Display(1);*/




            
        }
    }
}
