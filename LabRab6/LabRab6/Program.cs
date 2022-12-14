using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{

    internal class Предприятие
    {
        public int ID;
        public string name;
        public Предприятие(int pID, string pName)
        {
            ID = pID;
            name = pName;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine(name + ", ID - " + ID);
        }
    }
    internal class Склад : Предприятие
    {
        public int enough;

        public Склад(int pID, string pName, int pEnough) : base(pID, pName)
        {
            enough = pEnough;
        }
        override public void GetInfo()
        {
            Console.WriteLine(name + ", ID - " + ID + ", Вместимость -  " + enough);
        }
    }
    internal class ТоварнаяГруппа : Предприятие
    {
        public int kolvo;

        public ТоварнаяГруппа(int pID, string pName, int pKolvo) : base(pID, pName)
        {
            kolvo = pKolvo;
        }
        override public void GetInfo()
        {
            Console.WriteLine(name + ", ID -  " + ID + ", Количество - " + kolvo + " шт.");
        }
    }
    internal class Info<T> where T : Предприятие
    {

        public static void GetInf(T get)
        {
            get.GetInfo();
        }

        public static void GetID(T get)
        {
            Console.WriteLine(get.ID);
        }

    }
    class Programm
    {
        static void Main(string[] args)
        {
            Склад Склад1 = new Склад(718, "Cklad1", 290);
            ТоварнаяГруппа RuchkaPilot = new ТоварнаяГруппа(523, "Ruchka Pilot", 94);
            ТоварнаяГруппа CocaCola = new ТоварнаяГруппа(12, "CocaCola", 14);
            Info<Склад>.GetInf(Склад1);
            Info<ТоварнаяГруппа>.GetInf(RuchkaPilot);
            Info<ТоварнаяГруппа>.GetInf(CocaCola);
        }
    }
}