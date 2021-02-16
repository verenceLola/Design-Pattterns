using System;


namespace GameCharacters.Behaviours
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void useWeapon()
        {
            Console.WriteLine("cutting with a knife");
        }
    }
}
