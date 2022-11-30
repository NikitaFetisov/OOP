using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class ПО
    {
        public string name;
        protected string free;

        public ПО(string pName, string pFree)
        {
            name = pName;
            free = pFree;
        }
        virtual public string GetName()
        {
            return name;
        }
    }
}
