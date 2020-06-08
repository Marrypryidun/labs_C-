using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_v6_project
{
    class Enterprise
    {
        string name;
        string code_Projects;

        public Enterprise(string n, string c)
        {
            name = n;
            code_Projects = c;
        }
        public override string ToString()
        {
            return "Name of enterprise - " + this.Name + ". Code of the project " + this.Code_Projects ;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Code_Projects
        {
            get
            {
                return code_Projects;
            }
            set
            {
                code_Projects = value;
            }
        }
    }
}

    
