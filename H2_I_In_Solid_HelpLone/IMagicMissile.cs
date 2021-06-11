using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IMagicMissile
    {
        //This interface is responsible for the magic missile skill
        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}
