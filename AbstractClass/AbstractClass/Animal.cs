using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract internal class Animal
    {
        string Name;
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }

        abstract public void Eat();
    }
}
