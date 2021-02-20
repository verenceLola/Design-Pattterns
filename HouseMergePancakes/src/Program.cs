using HouseMergePancakes.Menus;


namespace HouseMergePancakes
{
    class MenuTestDrive
    {
        public static void Main(string[] args)
        {

            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CaféMenu caféMenu = new CaféMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, caféMenu);

            waitress.printMenu();
        }
    }
}
