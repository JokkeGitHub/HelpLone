using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IRaiseShield
    {
        //This interface is responsible for the raise shield skill
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
    }
}
