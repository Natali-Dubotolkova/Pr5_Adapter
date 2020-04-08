using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// Целевой класс
    /// </summary>
    class COM : ICOM
    {
        /// <summary>
        /// Функция, включающая СОМ-порт
        /// </summary>
        /// <returns>Подключенный СОМ-порт</returns>
        public string COM_Port()
        {
            return "COM Port";
        }
    }
}
