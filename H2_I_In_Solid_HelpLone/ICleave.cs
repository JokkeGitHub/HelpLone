using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface ICleave
    {
        //This interface is responsible for the cleave skill
        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
    }
}
