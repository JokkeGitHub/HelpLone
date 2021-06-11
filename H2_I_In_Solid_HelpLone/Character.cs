using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_I_In_Solid_HelpLone
{
    public abstract class Character
    {
        // This abstract class is responsible for characters
        private string _characterName;
        private int _healthPoints;
        private int _energy;

        public string CharacterName
        {
            get
            {
                return this._characterName;
            }
            set
            {
                this._characterName = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this._healthPoints;
            }
            set
            {
                this._healthPoints = value;
            }
        }

        public int Energy
        {
            get
            {
                return this._energy;
            }
            set
            {
                this._energy = value;
            }
        }

        public Character(string characterName, int healthPoints, int energy)
        {
            CharacterName = characterName;
            HealthPoints = healthPoints;
            Energy = energy;
        }
    }
}
