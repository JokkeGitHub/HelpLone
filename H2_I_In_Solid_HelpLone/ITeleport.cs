using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface ITeleport
    {
        //This interface is responsible for the teleport skill
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
