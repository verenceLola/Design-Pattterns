using HouseMergePancakes.Composite;
// using HouseMergePancakes.Menus;


namespace HouseMergePancakes
{
    class MenuTestDrive
    {
        public static void Main(string[] args)
        {

            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent caféMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(caféMenu);

            dinerMenu.add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", 3.99, true));
            dinerMenu.add(dessertMenu);
            dessertMenu.add(new MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla ice cream",
                1.59,
                true
            ));

            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
        }
    }
}
