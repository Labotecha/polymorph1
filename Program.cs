using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider provider;
            // programı test etmek için alttaki secim değişkenini 0 ve 1 yaparak deneyin
            int secim = 1;
            if (secim == 0)
            {
                provider = new Netgsm();
            }
            else
            {
                provider = new Sanalsantral();
            }
            provider.sendSMS(3, "hello");
            Console.ReadLine();
        }
    }
}
