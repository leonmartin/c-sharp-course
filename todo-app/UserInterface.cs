using System;
  
class UserInterface {

    public static string initMessage = """
        Please select one option by entering the according number.

        (1) Print all Todos.
        (2) Print Todo with top priority.
        (3) Add Todo.
        (4) Exit.
        """;

    public static void printAllTodos(List<Todo> todoList)
    {
        foreach (Todo todo in todoList)
        {
            Console.WriteLine(todo);
        }
    }
  
    public static void launchUserInterface(List<Todo> todoList)
    {
        while (true)
            {
                Console.WriteLine(initMessage);

                string chosenOption = Console.ReadLine() ?? "1";
                int option = Int16.Parse(chosenOption);

                switch (option)
                {
                    case 1:
                        printAllTodos(todoList);
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("This option is not available.");
                        break;
                }
            }
    }

}
