using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface ISlash
    {
        //This interface is responsible for the slash skill
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
