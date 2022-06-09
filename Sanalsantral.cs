using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    class Sanalsantral : Provider
    {
        //this.telNo = "8503228800";
        public override void sendSMS(int num, string msg)
        {
            Console.WriteLine("Sanal Santral tarafıdan " + num + " nolu telefona " + msg + " içerikli SMS gönderildi");
        }
    }
}
