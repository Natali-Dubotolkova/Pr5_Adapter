using System;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            COM user_com = new COM();

            Console.WriteLine("Подключаем СОМ-порт");
            Console.WriteLine(user_com.COM_Port());

            USB user_usb = new USB();
            ICOM pc_com = new Driver(user_usb);

            Console.WriteLine("Подключаем USB-порт");
            Console.WriteLine(pc_com.COM_Port());

            Console.ReadKey();
        }
    }
}