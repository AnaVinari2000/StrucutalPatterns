using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Example
{
    //component
    abstract class Component
    {

        public string Name { get; }

        public Component(string name)
        {
            Name = name;
        }
        //operation
        public abstract void Display(int level = 0);
    }
}
