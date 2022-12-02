using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.Notify += E;
            Person person1 = new Person("Радмир", "Футбол");
            Person person2 = new Person("Олег", "Концерт Коржа");
            Person person3 = new Person("Динар", "Кинотеатр"); 
            Console.Write("Введите интересующее вас событие: ");
            string s = Console.ReadLine();
            person1.Reaction(s);
            person2.Reaction(s);
            person3.Reaction(s);
            void E(Person sender, PersonEvent e)
            {
                Console.WriteLine($"Реакция {sender.GetName}: {e.Message}");
            }
        }
    }
}
