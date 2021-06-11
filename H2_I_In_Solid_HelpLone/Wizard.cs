using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    public class  Wizard : Character, IBaseSkills, IMagicMissile, IFrostNova, ITeleport
    {
        // This abstract class is responsible for the wizard class

        public Wizard(string characterName, int healthPoints, int energy) : base(characterName, healthPoints, energy)
        {
            CharacterName = characterName;
            HealthPoints = healthPoints;
            Energy = energy;
        }
    }
}
