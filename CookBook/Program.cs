using System;

namespace CookBook
{
    class Program
    {
        //Dodawanie przepisów
        // śniadania / obiady / kolacje / napoje / desery /sałatki
        // podział na kuchnię włoską / polska itd

        //Wyświetlanie przepisów
        //Usuwanie przepisów

        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            Console.WriteLine("Witaj w aplikacji książki kucharskiej");

            while (true)
            {
                Console.WriteLine("Wybierz akcję:");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                Console.WriteLine();
            }
           
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.addNewAction(1, "Dodaj przepis", "Main");
            actionService.addNewAction(2, "Remove recipe", "Main");
            actionService.addNewAction(3, "Show recipe", "Main");

            actionService.addNewAction(1, "Śniadania", "AddNewRecipe");
            actionService.addNewAction(2, "Obiady", "AddNewRecipe");
            actionService.addNewAction(3, "Kolacje", "AddNewRecipe");

            //actionService.addNewAction(1, "Dania kuchani polskiej", "Main");
            //actionService.addNewAction(1, "Dania kuchni włoskiej", "Main");
        }
    }
}
