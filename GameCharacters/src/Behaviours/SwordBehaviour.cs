using System;

namespace GameCharacters.Behaviours
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
