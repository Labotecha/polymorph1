using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    public abstract class Provider
    {
        public string telNo;

        public abstract void sendSMS(int tlf, string msg);
    }
}
