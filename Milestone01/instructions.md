# Milestone 01: Becoming Friends with C#

Good news, the wait is over. You will now write your first C# code. 🥳

But, before we dive into the conception and implementation of our banking application, we will do some introductory C# exercises first. The exercises are designed to specifically prepare you for the implementation of the banking app.

![Tutorial versus IDE](../pictures/tutorial_versus_ide.webp)

The objectives of this milestone are:

- Getting used to the C# syntax
- Learn how to use basic data types and structures
- Use loops and if-then-else constructs
- Create your first classes and objects
- Ask the user for input and parse it

## Task 01-1: Working with Different Data Types

Have a look at the [Program.cs file](./templates/task01-1/Program.cs) in the [template/task01-1 folder](./templates/task01-1/). This is the entry point for the following tasks. A few versions ago, so called [Top-Level Statements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/top-level-statements) were added to C#. They allow you to write your C# statements directly into an empty .cs file and run it without any additional boilerplate code. As you can see, in the top of the file there is the C# statement

```csharp
Console.WriteLine("Hm, doesn't look that difficult.");
```

which prints the string

```
"Hm, doesn't look that difficult."
```

on the console and a view output messages to your console when the program is executed. Go ahead and execute the program to make sure that everything works.

Within the file, you will find exercises for you to solve now. Remember that you can always consult the resources mentioned in the [README file](../README.md) if you are stuck. Try to solve the exercises yourself first before looking at the solutions (This is really important!).

Enjoy making your first steps in C#! 🥳

## Task 01-2: Loops and if-then-else Constructs

So far, you have used basic data types, invoked some methods on them, and read some of their properties. Did you notice that the program you wrote was executed in a linear fashion (cf. _Program 1_ below)? Now, we will add loops and if-then-else constructs which yields more complex control flows (cf. _Program 2_ below).

```mermaid
    flowchart TD;
        X1[Program 1 Start] --> A1;
        A1 --> B1;
        B1 --> C1;
        C1 --> D1;
        D1 --> Y1[Program 1 End];

        X2[Program 2 Start] --> A2;
        A2 --> B2;
        B2{Some if-then-else} --> C2;
        B2{Some if-then-else} --> D2;
        C2 --> E2;
        D2 --> E2;
        E2 -->|Some loop| A2;
        E2 --> Y2[Program 2 End];
```

Solve the exercises in the [Program.cs file](./templates/task01-2/Program.cs) in the [templates/task01-2 folder](./templates/task01-2/).

## Task 01-3: Creating your own Classes and Objects

Congratulations, you know the basic building blocks to control the flow of your C# program. And without thinking about it, you actually already used object-oriented programming. Every time you declared a variable and set its value you created an object, i.e. an instance of the class or struct specified as the type.

For instance,

```csharp
string myString = "This is my string!";
```

instantiates an object of the [String class](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) with `myString` as the name of the variable. Classes possess properties and methods. This is the reason why you can access properties like `Length` or call methods like `ToUpper()` of the String instance `myString`. Using a UML class diagram, we could visualize the (simplified) String class as follows:

```mermaid
    classDiagram
        class String{
            +int Length
            +...
            +ToUpper()
            +ToLower()
            +...()
        }
```

Next up, you will create your own classes and instantiate to access their properties and call their methods. Solve the exercises in the [Program.cs file](./templates/task01-3/Program.cs) in the [templates/task01-3 folder](./templates/task01-3/).

## Task 01-4: Processing User Input

Wow, even writing your own classes does not seem to be a problem for you. 😉

You are now in the final task of this milestone. Here, you will learn how to ask a user for input during the execution of a program via the command line and how to parse the input, effectively implementing a [CLI (Command-Line Interface)](https://en.wikipedia.org/wiki/Command-line_interface).

The exercises of this task will guide you through the implementation of a CLI that allows a user to input two numbers and perform calculations on them, as depicted in the UML Activity Diagram below. Solve the exercises in the [Program.cs file](./templates/task01-4/Program.cs) in the [templates/task01-4 folder](./templates/task01-4/).

```mermaid
    flowchart TD
        Start(( ))-->A(Ask user what they want to do)
        A-->B{ }
        B-->|Add|C(Ask for the two numbers)
        B-->|Subtract|D(Ask for the two numbers)
        C-->E(Add the two numbers)
        D-->F(Subtract the second from the first number)
        E-->G(Display the result)
        F-->G
        G-->A
        B-->|Exit|H(Quit the program)
        H-->Finish((( )))
 ```

## Task 01-5: Quiz Time

Congratulations, you took your first steps in the C# language!

To test wether you got the most important points of this milestone, answer the questions in the [quiz.md file](./quiz.md). When you are done, you can proceed to the next Milestone.
