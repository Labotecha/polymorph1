using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    class Sanalsantral : Provider
    {
        public Sanalsantral()
        {
	    telNo = 85011;
        }
        public override void sendSMS(string msg)
        {
            Console.WriteLine("Sanal Santral tarafıdan " + telNo + " nolu telefona " + msg + " içerikli SMS gönderildi");
        }
    }
}
