using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph1
{
    public abstract class Provider
    {
        public int telNo=22;

        public abstract void sendSMS(string msg);
    }
}
