Console.WriteLine("Hm, doesn't look that difficult.");

// Task 02.1: Working with Different Data Types

// Exercise 1
// Print a sentence on the console that states what your favorite animals are.

Console.WriteLine("Owls are my favorite animals.");

// Exercise 2
// Store the string from Exercise 1 in a variable.
// Print the variable on the console.

string favoriteAnimalString = "Owls are my favorite animals.";

Console.WriteLine(favoriteAnimalString);

// Exercise 3
// Store the string from Exercise 1 in a variable.
// Use a string method to change every character of the variable to upper case.
// Print the variable on the console afterwards.

string favoriteAnimalStringTwo = "Owls are my favorite animals.";
favoriteAnimalStringTwo = favoriteAnimalStringTwo.ToUpper();

Console.WriteLine(favoriteAnimalStringTwo);

// Exercise 4
// Store the string from Exercise 1 in a variable.
// Store a second sentence in another string variable.
// Print both strings on the console using only one Console.WriteLine statement.
// Make sure there is a space between both sentences in the output.

string favoriteAnimalStringThree = "Owls are my favorite animals.";
string secondString = "This is another sentence.";

Console.WriteLine(favoriteAnimalStringThree + " " + secondString);

// Exercise 5
// Store the string from Exercise 1 in a variable.
// Use a string property to get the number of characters in the string.
// Store the number of characters in a variable.
// Print the sentence on the console and add the length of sentence in brackets behind it.

string favoriteAnimalStringFour = "Owls are my favorite animals.";
int numberOfCharacters = favoriteAnimalString.Length;

Console.WriteLine(favoriteAnimalStringFour + " (" + numberOfCharacters + " characters)");

// Exercise 5
// Do the same as in Exercise 5 but print the result using string interpolation now.

string favoriteAnimalStringFive = "Owls are my favorite animals.";
int numberOfCharactersTwo = favoriteAnimalString.Length;

Console.WriteLine($"{favoriteAnimalStringFive} ({numberOfCharactersTwo} characters)");

// Exercise 5
// Do the same as in Exercise 5 but print the result using string interpolation now.

// Exercise 1
// Write a statement that prints your name on the console

// Task 02.2: Loops and if-then-else Constructs

// Task 02.3: Creating your own Classes and Objects

// Task 02.4: Processing User Input
