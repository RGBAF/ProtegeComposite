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
            Console.WriteLine("/addSlot - Создание и добавление слота (В разработке)");
            Console.WriteLine("/printSlot - Вывод слотов класса или инстанции (В разработке)");
            Console.WriteLine("/fillSlots - Заполнение слотов (В разработке)");
            Console.WriteLine("/makeQuery - Сделать запрос (В разработке)");
            Console.WriteLine("/helpQueryCommand (В разработке)");
        }
        static void Main(string[] args)
        {


            Component root = new Class("");
            Class tree = new Class("Tree");
            string command;
            root.Add(tree);
            string name;
            Console.WriteLine("Введите назавание онтологии:");
            name = Console.ReadLine();
            root.Insert("Tree", name);
            Console.WriteLine("Онтология создана");
            tree.Display(1);
            while (true)
            {

                Console.WriteLine("\nВведите команду(/help -информация о коммандах): ");
                command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "/help":
                        Info();
                        break;
                    case "/back":
                        tree.Display(1);
                        break;
                    case "/exit":
                        Environment.Exit(0);
                        break;
                    case "/addClass":
                        Console.WriteLine("Введите название нового класса: ");
                        string newNameClass = Console.ReadLine();
                        Console.WriteLine("Введите класс в который нужно добавить " + newNameClass);
                        name = Console.ReadLine();
                        root.Insert(name, newNameClass);
                        Console.WriteLine();
                        tree.Display(1);
                        break;
                    case "/addInstance":
                        Console.WriteLine("Введите название новой инстанции: ");
                        string newInstanceClass = Console.ReadLine();
                        Console.WriteLine("Введите класс в который нужно добавить " + newInstanceClass);

                        name = Console.ReadLine();
                        tree.InsertInstance(name, newInstanceClass);
                        Console.WriteLine();
                        tree.Display(1);
                        break;
                    case "/addSlot":
                        Console.WriteLine("Введите название слота: ");
                        string slotName = Console.ReadLine();
                        Console.WriteLine("Введите класс в который нужно добавить " + slotName + ":");
                        name = Console.ReadLine();
                        root.addSlot(name, slotName);
                        Console.WriteLine("Слот " + slotName + " добавлен в класс и его наследников!");
                        break;
                    case "/printSlot":
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует.\nВведите команду /help для просмотра информации о всех доступных командах!\n");

                        break;
                }
            }
        }
    }
}
