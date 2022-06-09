using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    class Netgsm : Provider
    {
        //this.telNo = "8503228800";
        public override void sendSMS(int num, string msg)
        {
            Console.WriteLine("Netgsm tarafıdan "+num+" nolu telefona "+msg+" içerikli SMS gönderildi");
        }

    }
}
