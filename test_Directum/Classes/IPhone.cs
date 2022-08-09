using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    public interface IPhone
    {
        string Number { get; set; }

        /// <summary>
        /// подключитсья к базе
        /// </summary>
        /// <param name="targetBase">выбранная база. Лучше наверное выбирать базу по какому-либо параметру. Например по уровню сигнала или по расстоянию</param>
        /// <returns>успех/неудача</returns>
        public bool ConnectToBase(IBase targetBase);

        /// <summary>
        /// звонок по номеру
        /// </summary>
        /// <param name="number">номер</param>
        /// <returns>успех/неудача</returns>
        public bool CallByNumber(string number);

        /// <summary>
        /// звонок по книге
        /// </summary>
        /// <param name="User">пользователь</param>
        /// <returns>успех/неудача</returns>
        public bool CallByUserName(User User);
    }


}
