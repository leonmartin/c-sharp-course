// Task 02.4: Processing User Input

// Exercise 1
// 1. Instantiate the Calculator.
// 1. Print the options the user has on the console.
// 2. Ask the user to select one of the options.
// 3. Print the selected option.

// Exercise 2
// Extend the code from the previous exercise for this one.
// 4. Use an if-then-else construct to execute code depending on the selected option.
//      - If the user wants to add or subtract two numbers, ask for the two numbers, parse them, and use the Calculator to get the result.
//      - If the user wants to exit the program, terminate it using an appropriate method.

// Exercise 3
// Extend the code from the previous exercise for this one.
// 5. Put everything that shall be repeated after a user interaction in a never-ending loop. 

Calculator myCalculator = new Calculator();

while (true)
{

    Console.WriteLine("""
    Your options are:
    (1) Add numbers
    (2) Subtract numbers
    (3) Exit the program
    Enter one of the numbers to select one option:
    """);

    string chosenOption = Console.ReadLine() ?? "0";

    if (chosenOption == "1")
    {
        Console.WriteLine("Please enter two numbers and hit enter in between:");
        string numberOneString = Console.ReadLine() ?? "0";
        string numberTwoString = Console.ReadLine() ?? "0";

        double numberOne = Double.Parse(numberOneString);
        double numberTwo = Double.Parse(numberTwoString);

        double sum = myCalculator.Add(numberOne, numberTwo);
        
        Console.WriteLine($"The result is: {sum}");
    }
    else if (chosenOption == "2")
    {
        Console.WriteLine("Please enter two numbers and hit enter in between::");
        string numberOneString = Console.ReadLine() ?? "0";
        string numberTwoString = Console.ReadLine() ?? "0";

        double numberOne = Double.Parse(numberOneString);
        double numberTwo = Double.Parse(numberTwoString);

        double difference = myCalculator.Subtract(numberOne, numberTwo);

        Console.WriteLine($"The result is: {difference}");
    }
    else if (chosenOption == "3")
    {
        Console.WriteLine("Bye Bye!");
        System.Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("This option is not supported!");
    }
}
