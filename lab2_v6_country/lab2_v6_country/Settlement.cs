using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_v6_country
{
    class Settlement : Component
    {
        
        public Settlement(string name)
        : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
        public override bool Search(string s)
        {
           
            
            if (name == s)
            {
                Console.WriteLine(s + " знайдено серед населених пунктiв " );
                return true;
            }
            else
                return false;
        }
    }
}
