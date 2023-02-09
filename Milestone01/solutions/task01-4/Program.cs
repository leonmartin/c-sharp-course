// Task 01.4: Processing User Input

// Exercise 1
// 1. Instantiate the Calculator.
// 1. Print the options the user has on the console.
// 2. Ask the user to select one of the options.
// 3. Print the selected option.

// Exercise 2
// Extend the code from the previous exercise for this one.
// 4. Use a switch to execute code depending on the selected option.
//      - If the user wants to add or subtract two numbers, ask for the two numbers, parse them, and use the Calculator to get the result.
//      - If the user wants to exit the program, terminate it using an appropriate method.

// Exercise 3
// Extend the code from the previous exercise for this one.
// 5. Put everything that shall be repeated after a user interaction in a never-ending while loop. 

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

    string chosenOption = Console.ReadLine() ?? "";
    string numberOneString = "";
    string numberTwoString = "";
    double numberOne = 0;
    double numberTwo = 0;

    switch (chosenOption)
    {

        case "1":
            Console.WriteLine("Please enter two numbers and hit enter in between:");
            numberOneString = Console.ReadLine() ?? "0";
            numberTwoString = Console.ReadLine() ?? "0";

            numberOne = Double.Parse(numberOneString);
            numberTwo = Double.Parse(numberTwoString);

            double sum = myCalculator.Add(numberOne, numberTwo);

            Console.WriteLine($"The sum of the two numbers is {sum}");
            break;

        case "2":
            Console.WriteLine("Please enter two numbers and hit enter in between::");
            numberOneString = Console.ReadLine() ?? "0";
            numberTwoString = Console.ReadLine() ?? "0";

            numberOne = Double.Parse(numberOneString);
            numberTwo = Double.Parse(numberTwoString);

            double difference = myCalculator.Subtract(numberOne, numberTwo);

            Console.WriteLine($"The difference of the two numbers is {difference}");
            break;

        case "3":
            Console.WriteLine("Bye Bye!");
            System.Environment.Exit(0);
            break;

        default:
            Console.WriteLine("This option is not supported!");
            break;
    }
}
