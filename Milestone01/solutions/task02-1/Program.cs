Console.WriteLine("Hm, doesn't look that difficult.");

// Task 02.1: Working with Different Data Types

// Exercise 1
// 1. Print a sentence on the console that states what your favorite animals are.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 1 *****\n");

Console.WriteLine("Owls are my favorite animals.");

// Exercise 2
// 1. Store the string from Exercise 1 in a variable.
// 2. Print the variable on the console.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 2 *****\n");

string favoriteAnimalString = "Owls are my favorite animals.";

Console.WriteLine(favoriteAnimalString);

// Exercise 3
// 1. Store the string from Exercise 1 in a variable.
// 2. Use a string method to change every character of the variable to upper case.
// 3. Print the variable on the console afterwards.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 3 *****\n");

string favoriteAnimalStringTwo = "Owls are my favorite animals.";
favoriteAnimalStringTwo = favoriteAnimalStringTwo.ToUpper();

Console.WriteLine(favoriteAnimalStringTwo);

// Exercise 4
// 1. Store the string from Exercise 1 in a variable.
// 2. Store a second sentence in another string variable.
// 3. Print both strings on the console using only one Console.WriteLine statement.
// Make sure there is a space between both sentences in the output.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 4 *****\n");

string favoriteAnimalStringThree = "Owls are my favorite animals.";
string secondString = "This is another sentence.";

Console.WriteLine(favoriteAnimalStringThree + " " + secondString);

// Exercise 5
// 1. Store the string from Exercise 1 in a variable.
// 2. Use a string property to get the number of characters in the string.
// 3. Store the number of characters in a variable.
// 4. Print the sentence on the console and add the length of sentence in brackets behind it.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 5 *****\n");

string favoriteAnimalStringFour = "Owls are my favorite animals.";
int numberOfCharacters = favoriteAnimalStringFour.Length;

Console.WriteLine(favoriteAnimalStringFour + " (" + numberOfCharacters + " characters)");

// Exercise 6
// 1. Do the same as in Exercise 5 but print the result using string interpolation now.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 6 *****\n");

string favoriteAnimalStringFive = "Owls are my favorite animals.";
int numberOfCharactersTwo = favoriteAnimalStringFive.Length;

Console.WriteLine($"{favoriteAnimalStringFive} ({numberOfCharactersTwo} characters)");

// Exercise 7
// In ASCII encoding, each character needs 7 bits.
// 1. Store an arbitrary sentence in a string variable.
// 2. Calculate the number of bits this string needs in ASCII encoding.
// 3. Store the number of bits in a variable.
// 4. Print the sentence on the console and add the number of bits in brackets behind it using string interpolation.
Console.WriteLine("\n***** Output of Task02.1 - Exercise 7 *****\n");

string favoriteAnimalStringSix = "Owls are my favorite animals.";
int numberOfCharactersThree = favoriteAnimalStringSix.Length;
int numberOfBits = numberOfCharacters * 7;

Console.WriteLine($"{favoriteAnimalStringSix} ({numberOfBits} bits)");
