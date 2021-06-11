using System;

namespace H2_I_In_Solid_HelpLone
{
    class Program
    {
        static void Main(string[] args)
        {
            Character barbarian = new Barbarian("Hugo", 100, 50);

            if (barbarian is IShieldGlare)
            {
                ((IShieldGlare)barbarian).ShieldGlare();
            }
            if (barbarian is ISlash)
            {
                ((ISlash)barbarian).Slash();
            }
        }
    }
}
