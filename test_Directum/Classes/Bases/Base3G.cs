using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    /// <summary>
    /// класс базы с 3g
    /// подвязываем только телефоны 3g
    /// если нужнодобавлять любые телефоны, то оставляем только "спец" обработку привызове 
    /// </summary>
    public class Base3G : IBase
    {
        public List<IPhone> Phones { get; set; }
        public new bool Call(IPhone dest, string number) {
            //специальная обработка
            if (Phones.Where(x => x.Number == number).Count() > 0)
            {
                //тут можно открыть свзяь между тем с кем связываемся и dest, для передачи потока свзяи
                //пока просто ставим статус ОК
                return true;
            }
            return false;
        }

        public new bool RegPhone(IPhone phone)
        {
            if (phone.GetType() != typeof(Phone3G))
                return false;
            if (Phones == null)
            {
                Phones = new List<IPhone>();
            }
            if (Phones.Any(x => x.Number == phone.Number))
                return false;

            Phones.Add(phone);
            return true;
        }
    }
}
