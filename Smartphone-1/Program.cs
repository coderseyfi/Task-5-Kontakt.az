using System;
using ClassLibrary.Helpers;

namespace Smartphone_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Smartphone Store";

            int len;

        back:

            len = Monitor.ReadInteger("How many phone brands are you interested in? : ");
            if (len <=0)
            {
                goto back;
            }
            Iphones[] tels = new Iphones[len];

            for (int i = 0; i < tels.Length; i++)
            {

                Iphones tel = new Iphones();
                

                tel.name = Monitor.ReadString($"{i+1}.Smartphone Name: ");
                tel.producer = Monitor.ReadString($"{i+1}.Smartphone Producer: ");
                tel.type = Monitor.ReadString($"{i+1}.Smartphone Type: ");
                tel.bluetoothVersion = Monitor.ReadString($"{i+1}.Bluetooth Version: ");
                tel.price = Monitor.ReadInteger($"{i+1}.Smartphone Price: ");
                tel.memory = Monitor.ReadInteger($"{i+1}.Smartphone's Mmemory: ");
                tel.cores = Monitor.ReadInteger($"{i+1}.Cores: ");
                tel.year = Monitor.ReadInteger($"{i+1}.Production year: ");
                tel.weight = Monitor.ReadInteger($"{i+1}.Weight: ");

                tels[i] = tel;
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("################ List of Smartphones ###############");

            foreach (var item in tels)
            {
                Console.WriteLine(item);
                Console.WriteLine("*********************");
            }

            Console.ReadKey();
        }
    }
}
