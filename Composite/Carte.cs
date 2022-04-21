using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Example
{
    class Carte : Component
    {

        private List<Component> _components = new List<Component>();

        public Carte(string name) : base(name)
        {

        }

        public override void Display(int level = 0)
        {
            string spaces = new string(' ', level);
            Console.WriteLine(spaces + "└ " + Name);

            foreach (var component in _components)
                component.Display(level + 1);
        }

        public void AddComponent(Component component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            _components.Remove(component);
        }
    }
}
