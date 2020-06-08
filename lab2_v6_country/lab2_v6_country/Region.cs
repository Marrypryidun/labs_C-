using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_v6_country
{
    class Region : Component
    {
        List<Component> children = new List<Component>();
        
        public Region(string name)
            : base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name + "/" );

            foreach (Component component in children)
            {
                component.Display();
            }
        }
        public override bool Search(string s)
        {
           // string element;
           // element = "країн";
            if (name == s)
            {
                Console.WriteLine(s+" знайдено.");
                return true;
            }
            else if (name != s)
            {
                
                foreach (Component component in children)
                {
                    if (component.Search(s) == true)
                    {
                        //Console.WriteLine(s + " знайдено " /*+ element*/);
                        return true;
                    }

                }
            }
            
             //Console.WriteLine(s + "- не знайдено "/*+ element*/);
             return false;
            

        }
    }
}
