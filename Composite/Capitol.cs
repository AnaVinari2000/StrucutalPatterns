using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Example
{
    //leaf
    class Capitol : Component
    {

        public Capitol(string Name) : base(Name)
        {

        }

        public override void Display(int level = 0)
        {
            string spaces = new string(' ', level);
            Console.WriteLine(spaces + "└ " + Name);
        }
    }
}
