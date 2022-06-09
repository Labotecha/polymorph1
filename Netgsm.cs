using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    class Netgsm : Provider
    {
        public Netgsm()
        {
	    telNo = 85000;
        }
        public override void sendSMS(string msg)
        {
            Console.WriteLine("Netgsm tarafıdan "+telNo+" nolu telefona "+msg+" içerikli SMS gönderildi");
        }

    }
}
