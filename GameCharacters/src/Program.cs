using System;
using GameCharacters.Entities;
using GameCharacters.Behaviours;

namespace GameCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Character king = new King();
            king.setWeapon(new SwordBehaviour());
            king.fight();

            Character queen = new Queen();
            queen.setWeapon(new AxeBehaviour());
            queen.fight();
        }
    }
}
