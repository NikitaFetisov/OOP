using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Прикладное : ПО
    {
        protected string Author;

        public Прикладное (string pName, string pFree, string pAuthor) : base(pName, pFree)
        {
            Author = pAuthor;
        }
        public override string GetName()
        {
            return name + " Производитель ПО - " + Author;
        }
    }
}
