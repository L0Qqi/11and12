using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class Person
    {
        string name;
        public delegate void ThisEvent(Person person, PersonEvent e);
        public static event ThisEvent Notify;
        public Person(string name, string meropriyatie)
        {
            this.name = name;
            Meropriyatie = meropriyatie.ToLower();
        }
        public string GetName
        {
            get { return name; }
        }
        string Meropriyatie { get; set; }
        public void Reaction(string s)
        {
            if (Meropriyatie.Contains(s.ToLower()))
                Notify?.Invoke(this, new PersonEvent("Кайф!"));
            else
                Notify?.Invoke(this, new PersonEvent("Не надо мне такого"));
        }
    }
}
