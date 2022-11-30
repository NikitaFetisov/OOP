using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class СвободныеОС : ОС
    {
        protected string Local;
        public СвободныеОС (string pName, string pFree, string pLocal, string pSystem) : base(pName, pFree, pSystem )
        {
            Local = pLocal;
        }
        public override string GetName()
        {
            return name + "тип ОС - " + Local;
        }
    }
}
