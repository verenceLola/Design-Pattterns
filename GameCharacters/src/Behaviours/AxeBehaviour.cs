using System;


namespace GameCharacters.Behaviours
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}
