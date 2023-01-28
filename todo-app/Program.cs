using System;
using System.Collections.Generic;
  
class Program {
  
    // Main Method
    static void Main()
    {
        Todo firstTodo = new Todo("My first Todo", 10, "This is just a test.");
        Todo secondTodo = new Todo("My second Todo", 5, "This is just another test.");
        Todo thirdTodo = new Todo("My third Todo", 7, "Seriously? More tests?");

        List<Todo> defaultTodoList = new List<Todo>();
        
        defaultTodoList.Add(firstTodo);
        defaultTodoList.Add(secondTodo);
        defaultTodoList.Add(thirdTodo);

        UserInterface.launchUserInterface(defaultTodoList);

    }
}
