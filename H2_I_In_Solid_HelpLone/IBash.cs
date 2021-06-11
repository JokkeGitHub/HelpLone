using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IBash
    {
        //This interface is responsible for the bash skill
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }
    }
}
