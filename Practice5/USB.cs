using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// Адаптируемый класс содержит некоторое полезное поведение, но его
    /// интерфейс несовместим  с существующим клиентским кодом. Адаптируемый
    /// класс нуждается в некоторой доработке,  прежде чем клиентский код сможет
    /// его использовать.
    /// </summary>
    class USB
    {
        /// <summary>
        /// Функция, включающая USB-порт
        /// </summary>
        /// <returns>Подключенный USB-порт</returns>
        public string USB_Port()
        {
            return "USB Port";
        }
    }
}
