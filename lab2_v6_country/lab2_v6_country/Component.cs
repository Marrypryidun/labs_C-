using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_v6_country
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract bool Search(string s);
    }
}
