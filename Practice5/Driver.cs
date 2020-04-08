using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
    /// интерфейсом.
    /// </summary>
    class Driver : ICOM
    {
        private readonly USB _usb;

        public Driver(USB usb)
        {
            this._usb = usb;
        }

        /// <summary>
        /// Функция адаптера, которая в СОМ-порт подключает USB-порт
        /// </summary>
        /// <returns></returns>
        public string COM_Port()
        {
            return $"This is '{this._usb.USB_Port()}'";
        }
    }
}
