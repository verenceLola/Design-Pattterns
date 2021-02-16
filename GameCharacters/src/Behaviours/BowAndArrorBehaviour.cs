using System;

namespace GameCharacters.Behaviours
{
    public class BowAndArrorBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            Console.WriteLine("Using Bow and Arrow");
        }
    }
}
