// Task 02.2: Loops and if-then-else Constructs

// Exercise 1
// Have a look at the following array of numbers.
// 1. Use a for each loop to iterate the array and print each number.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 1 *****\n");

double[] myNumbers = { 234.5, 12.0, 34666.43, 5.9, 55.99, 213.2 };

foreach (double number in myNumbers)
{
    Console.WriteLine(number);
}

// Exercise 2
// 1. Use a for loop to iterate the array from Exercise 1 and print each number.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 2 *****\n");

for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}

// Exercise 3
// 1. Use a while loop to iterate the array from Exercise 1 and print each number.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 3 *****\n");

int counter = 0;

while (counter < myNumbers.Length)
{
    Console.WriteLine(myNumbers[counter]);
    counter++;
}

// Exercise 4
// 1. Use a for each loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to only print the numbers that are less than or equal 12.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 4 *****\n");

foreach (double number in myNumbers)
{
    if (number <= 12)
    {
        Console.WriteLine(number);
    }
}

// Exercise 5
// 1. Use a for each loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to only sum up the numbers that are bigger than 12.
// 3. Print the total sum.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 5 *****\n");

double sum = 0;

foreach (double number in myNumbers)
{
    if (number > 12)
    {
        sum += number;
    }
}

Console.WriteLine(sum);

// Exercise 6
// 1. Use a for each loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to print a sentence stating that the current number is less than/equal or a sentence stating that the current number is bigger than 12.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 6 *****\n");

foreach (double number in myNumbers)
{
    if (number > 12)
    {
        Console.WriteLine($"{number} is bigger than 12.");
    }
    else
    {
        Console.WriteLine($"{number} is less than or equals 12.");
    }
}

// Exercise 7
// 1. Use a for each loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to print a sentence stating that the current number is less than/equal or a sentence stating that the current number is bigger than 12.
Console.WriteLine("\n***** Output of Task02.2 - Exercise 7 *****\n");

foreach (double number in myNumbers)
{
    if (number < 12)
    {
        Console.WriteLine($"{number} is less than 12.");
    }
    else if (number > 234)
    {
        Console.WriteLine($"{number} is bigger than 234.");
    }
    else
    {
        Console.WriteLine($"{number} is between 12 and 234.");
    }
}
