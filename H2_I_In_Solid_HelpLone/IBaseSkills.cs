using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    interface IBaseSkills
    {
        //This interface is responsible for the base skills
        //The reason why i made this an interface, is to be able to add more base skills, without touching the super class
        //And another reason is, if I want to make an NPC, then that character should not necessarily have a contract with the base skills,
        // the npc might only need a IQuest contract, or ITalk
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
