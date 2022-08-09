using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    /// <summary>
    /// интерфейс базы
    /// учитываем, что базы не связываются между собой. Но если должны, то надо связать базы и навесить ретрансляцию на Send
    /// </summary>
    public interface IBase
    {
        /// <summary>
        /// все быза должны уметь регистрировать телефоны
        /// </summary>
        /// <param name="phone">собвтенно телефон</param>
        /// <returns>успез/неудача</returns>
        public bool RegPhone(IPhone phone);
        /// <summary>
        /// все базы должны уметь пересылать звонок
        /// </summary>
        /// <param name="dest">источник</param>
        /// <param name="number">номер</param>
        /// <returns>успех/неудача</returns>
        public bool Call(IPhone dest, string number);
    }
}
