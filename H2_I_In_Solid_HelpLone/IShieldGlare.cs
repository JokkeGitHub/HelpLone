using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IShieldGlare
    {
        //This interface is responsible for the shield glare skill
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
    }
}
