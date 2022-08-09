using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    public class Base : IBase
    {
        public List<IPhone> Phones { get; set; }

        /// <summary>
        /// звоним
        /// </summary>
        /// <param name="dest">пересылаем звонок от</param>
        /// <param name="number"> кому звоним</param>
        /// <returns>созвонились или нет</returns>
        public bool Call(IPhone dest, string number)
        {
            if (Phones.Where(x => x.Number == number).Count() > 0)
            {
                //тут можно открыть свзяь между тем с кем связываемся и dest, для передачи потока свзяи
                //пока просто ставим статус ОК
                return true;
            }
            return false;
        }

        public bool RegPhone(IPhone phone)
        {
            if (Phones == null)
            {
                Phones = new List<IPhone>();
            }

            Phones.Add(phone);
            return true;
        }
    }
}
