﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IBaseSkills
    {
        //
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
    }
}