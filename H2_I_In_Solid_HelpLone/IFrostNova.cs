using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IFrostNova
    {
        //This interface is responsible for the frostnova skill
        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }
    }
}
