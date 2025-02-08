using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem;
using static TCSA.OOP.LibraryManagement.Enums;

namespace TCSA.OOP.LibraryManagement;

internal class UserInterface
{
    private BooksController booksController = new BooksController();
    internal  void MainMenu()
    {
        /* Next we need to make sure the menu runs again after an operation is completed. 
         * For this, just put it in a loop. 
         * Notice we're also clearing the console with the Clear() method to improve readability*/
        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
                     new SelectionPrompt<MenuOption>()
                     .Title("What do you want to do next?")
                     .AddChoices(Enum.GetValues<MenuOption>()));

            /* Now, inside the loop, let's create a switch statement to handle each option.
             * The switch statement will branch the execution of the code based on the choice variable*/
            switch (choice)
            {
                case MenuOption.ViewBooks:
                    booksController.ViewBooks();
                    break;

                case MenuOption.AddBook:
                    booksController.AddBook();
                    break;

                case MenuOption.DeleteBook:
                    booksController.DeleteBook();
                    break;
            }
        }
    }
}
}
