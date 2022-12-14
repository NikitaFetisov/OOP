using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class AuthorizeInfo
    {
        private string login;
        private string password;

        public AuthorizeInfo(string pLogin, string pPassword)
        {
            login = pLogin;
            password = pPassword;
        }

        public override Boolean Equals(Object ob)
        {
            if (!(ob is AuthorizeInfo)) return false;
            AuthorizeInfo authorizeInfo = (AuthorizeInfo)ob;
            if ((this.login.Equals(authorizeInfo.login)) && (this.password.Equals(authorizeInfo.password))) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            int res = 1;
            res = (res * 31) + login.Length;
            res = (res * 31) + password.Length;
            return res;
        }
    }
    internal class UserInfo
    {
        public string fio { get; private set; }
        public string mail { get; private set; }
        public string city { get; private set; }
        public UserInfo(string pFio, string pMail, string pCity)
        {
            fio = pFio;
            mail = pMail;
            city = pCity;
        }
    }
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data = new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Новак", "1"), new UserInfo("Новак О.К.", "Новак.O.K.@mail.ru", "Сочи"));
            data.Add(new AuthorizeInfo("Сторзаев", "2"), new UserInfo("Сторзаев М.К.", "Сторзаев.@mail.ru", "Лондон"));
            data.Add(new AuthorizeInfo("Гумин", "3"), new UserInfo("Гумин А.Е.", "Гумин.A.E.@mail.ru", "Москва"));
            data.Add(new AuthorizeInfo("Фетисов", "4"), new UserInfo("Фетисов Н.А", "Фетисов@mail.ru", "Ставрополь"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if (data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            UserStorage task = new UserStorage();
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string pass = Console.ReadLine();
            UserInfo info = task.GetUser(new AuthorizeInfo(login, pass));
            if (info != null)
            {
                Console.WriteLine(info.fio + "\n" + info.mail + "\n" + info.city);
            }
            else
            {
                Console.WriteLine("Пользователь не найден в базе данных");
            }
        }
    }

}
