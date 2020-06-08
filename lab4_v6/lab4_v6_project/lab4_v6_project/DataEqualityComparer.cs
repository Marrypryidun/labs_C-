using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_v6_project
{
    class DataEqualityComparer: IEqualityComparer<Enterprise>
    {
        public bool Equals(Enterprise x, Enterprise y)
        {
            bool Result = false;
            if (x.Name == y.Name && x.Code_Projects == y.Code_Projects)
                Result = true;
            return Result;
        }
        public int GetHashCode(Enterprise obj)
        {
            return obj.Code_Projects.GetHashCode();
        }

    }
}
