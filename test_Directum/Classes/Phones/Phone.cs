using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    public class Phone : IPhone
    {
        /// <summary>
        /// пока ставим GUID для простой генерации
        /// </summary>
        public Guid IMEI { get; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// книга контактов
        /// </summary>
        public List<User> UserBook;

        protected IBase CurrentBase { get; set; }


        /// <summary>
        /// генерируем телефон
        /// </summary>
        /// <param name="number">номер мы берем от симки</param>
        /// <param name="userBook">книгу контактов мы берем из какого-то хранилища(ПЗУ/БД)</param>
        public Phone(string number, List<User> userBook)
        {
            IMEI = Guid.NewGuid();
            Number = number;
            UserBook = userBook;
        }


        public bool CallByNumber(string number)
        {
            return (CurrentBase==null)?false:CurrentBase.Call(this, number);
        }

        public bool CallByUserName(User User)
        {
            return CallByNumber(User.Number);
        }

        public bool ConnectToBase(IBase targetBase)
        {
            if (targetBase.RegPhone(this))
            {
                CurrentBase = targetBase;
                return true;
            }
            return false;
        }
    }
}
