// Task 02.3: Creating your own Classes and Objects

// Exercise 1
// Have a look the Calculator class in the Calculator.cs file in this folder.
// 1. Create an object by instantiating the Calculator class.
// 2. Call the Add method of the object using two double objects.
// 3. Print the result of the calculation.
Console.WriteLine("\n***** Output of Task02.3 - Exercise 1 *****\n");

Calculator myCalculator = new Calculator();

double numberOne = 2.3;
double numberTwo = 4.66;

double sum = myCalculator.Add(numberOne, numberTwo);

Console.WriteLine(sum);

// Exercise 2
// 1. Implement another method called Subtract in the Calculator class that takes two double objects as input, subtracts the second from the first one, and returns the result.
// 2. Call the Subtract method of the object using two double objects.
// 3. Print the result of the calculation.
Console.WriteLine("\n***** Output of Task02.3 - Exercise 2 *****\n");

Calculator myCalculatorTwo = new Calculator();

double difference = myCalculatorTwo.Subtract(numberOne, numberTwo);

Console.WriteLine(difference);

// Exercise 3
// 1. Add a List called PreviousResults as a property to the Calculator class. You have to import the List object from System.Collections.Generic to do that.
// 2. Adjust the Add und Subtract such that the respective result is added to PreviousResults before it is returned.
// 3. Make some calculations using the Calculator.
// 4. Use a foreach loop to iterate the PreviousResults property and print each of them.
Console.WriteLine("\n***** Output of Task02.3 - Exercise 3 *****\n");

Calculator myCalculatorThree = new Calculator();

myCalculatorThree.Subtract(12, 5);
myCalculatorThree.Add(435.1, 123.4);
myCalculatorThree.Subtract(5, 12);

foreach (double result in myCalculatorThree.PreviousResults)
{
    Console.WriteLine(result);
}
