using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class ОС : ПО
    {
        protected string System;
        public ОС(string pName, string pFree, string pSystem) : base(pName, pFree)
        {
            System = pSystem;
        }
        public override string GetName()
        {
            return name + " Тип системы - " + System;
        }
    }
}
