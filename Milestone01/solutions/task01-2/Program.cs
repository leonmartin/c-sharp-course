// Task 01.2: Loops and if-then-else Constructs

// Exercise 1
// Have a look at the following array of numbers.
// 1. Use a for each loop to iterate the array and print each number.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 1 *****\n");

double[] myNumbers = { 234.5, 12.0, 34666.43, 5.9, 55.99, 213.2 };

foreach (double number in myNumbers)
{
    Console.WriteLine(number);
}

// Exercise 2
// 1. Use a for loop to iterate the array from Exercise 1 and print each number.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 2 *****\n");

for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}

// Exercise 3
// 1. Use a while loop to iterate the array from Exercise 1 and print each number.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 3 *****\n");

int counter = 0;

while (counter < myNumbers.Length)
{
    Console.WriteLine(myNumbers[counter]);
    counter++;
}

// Exercise 4
// 1. Use a foreach loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to only print the numbers that are less than or equal 12.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 4 *****\n");

foreach (double number in myNumbers)
{
    if (number <= 12)
    {
        Console.WriteLine(number);
    }
}

// Exercise 5
// 1. Use a foreach loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to only sum up the numbers that are bigger than 12.
// 3. Print the resulting sum.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 5 *****\n");

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
// 1. Use a foreach loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to print a sentence stating that the current number is less than/equal or a sentence stating that the current number is bigger than 12.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 6 *****\n");

foreach (double number in myNumbers)
{
    if (number <= 12)
    {
        Console.WriteLine($"{number} is less than or equal 12.");
    }
    else
    {
        Console.WriteLine($"{number} is bigger than 12.");
    }
}

// Exercise 7
// 1. Use a foreach loop to iterate the array from Exercise 1.
// 2. Use a if-then-else construct to print a sentence stating that the current number is less than 12, a sentence stating that the current number is bigger than 234, or a sentence stating that the current number is between 12 and 234.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 7 *****\n");

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

// Exercise 8
// 1. Do the same as in Exercise 7 but use a switch statement for the case differentiation this time.
Console.WriteLine("\n***** Output of Task01.2 - Exercise 8 *****\n");

foreach (double number in myNumbers)
{
    switch (number)
    {
        case < 12:
            Console.WriteLine($"{number} is less than 12.");
            break;

        case > 234:
            Console.WriteLine($"{number} is bigger than 234.");
            break;

        default:
            Console.WriteLine($"{number} is between 12 and 234.");
            break;
    }
}
