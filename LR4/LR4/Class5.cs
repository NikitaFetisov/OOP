using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class ПлатныеОС : ОС
    {
        protected int Price;
        public ПлатныеОС(string pName, string pFree, int pPrice, string pAuthor, string pSystem) : base(pName, pFree, pSystem)
        {
            Price = pPrice;
        }
        public override string GetName()
        {
            return name + "Стоимость - " + Price.ToString() + "руб. ";
        }
    }
}
