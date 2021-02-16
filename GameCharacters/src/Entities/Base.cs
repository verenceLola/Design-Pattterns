using GameCharacters.Behaviours;

namespace GameCharacters.Entities
{
    public abstract class Character
    {

        public IWeaponBehaviour weaponBehaviour;
        public void fight()
        {
            weaponBehaviour.useWeapon();
        }
        public void setWeapon(IWeaponBehaviour wb)
        {
            weaponBehaviour = wb;
        }
    }
}
