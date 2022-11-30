using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class programm
    {
        static void Main(string[] args)
        {
            var list = new List<ПО>();
            var a1 = new ПО("Калькулятор ", " бесплатно"); list.Add(a1);
            var a2 = new ОС("Windows ", " Платно", "Система реального времени"); list.Add(a2);
            var a3 = new Прикладное("Chrome", " бесплатно", "Google"); list.Add(a3);
            var a4 = new СвободныеОС("Linux ", " бесплатно", "Локальная", "Система реального времени"); list.Add(a4);
            var a5 = new ПлатныеОС("Mac OS ", " Платно", 15000, "Apple", "Система реального времени"); list.Add(a5);
            var a6 = new Прикладное("Visual Studio ", " бесплатно", "Microsoft"); list.Add(a6);
            var a7 = new Прикладное("WinRAR ", " платно", "Microsoft"); list.Add(a7);
            foreach(var item in list)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
