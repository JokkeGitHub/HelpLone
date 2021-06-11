using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    public class Witch : Character, IBaseSkills, ITeleport, IRaiseShield, IShieldGlare
    {
        // This abstract class is responsible for the witch class

        public Witch(string characterName, int healthPoints, int energy) : base(characterName, healthPoints, energy)
        {
            CharacterName = characterName;
            HealthPoints = healthPoints;
            Energy = energy;
        }
    }
}
