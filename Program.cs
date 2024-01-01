// Creating a Random Object:
// The Random class in C# is used for generating random numbers.
// When you create a Random object using 'new Random()', it initializes with a specific seed value,
// often based on the current time. This seed is crucial for generating pseudo-random numbers.
// Each time you create a new Random object, you essentially start with a new sequence of random numbers
// based on a different seed.

//Random dice = new Random();

// Stateful Method (Next Method):
// The Next method in the Random class is a stateful method because it generates random numbers
// based on the internal state of the Random object.
// The internal state of the Random object includes the current seed value and other variables
// required to ensure that the generated numbers appear random.
// By calling Next on the same Random object, you continue with the sequence of numbers generated
// from the same internal state.

//int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Truly Random vs. Pseudo-Random:
// In computing, truly random numbers are challenging to generate because computers are deterministic machines.
// Instead, most random number generators produce pseudo-random numbers.
// Pseudo-random numbers are generated using algorithms and initial seed values.
// The generated sequence appears random but is entirely determined by the algorithm and seed.
// Random uses a pseudo-random number generator (PRNG) that starts with a seed and generates a sequence
// of numbers that is statistically random.

// The 'new' Keyword:
// The 'new' keyword in C# is used to create instances (objects) of classes.
// When you create a Random object with 'new Random()', it means you're instantiating a new instance
// of the Random class, and this instance will have its own internal state separate from other instances
// of Random.

// Seeding the PRNG:
// You can also provide a specific seed value when creating a Random object, which can be useful when
// you want reproducible sequences of random numbers.
// For example, using 'new Random(SeedValue)' will produce the same sequence of random numbers
// every time if you provide the same seed value.

// // // RECAP // // //
// ~~~ ~~~ ~~~ ~~~  //

// Calling Methods in .NET Class Library:
// To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(),
// where the . symbol is the member access operator to access a method defined on the class,
// and the () symbols are the method invocation operators.

// Stateless vs. Stateful Methods:
// - Stateless methods can be called directly without creating an instance of the class.
// - Stateful methods require you to create an instance (object) of the class before accessing the method.

// Creating Instances (Objects) of Classes:
// To use stateful methods, you need to create an instance of the class using the new operator.
// An instance of a class is referred to as an object and allows you to access the methods and properties
// defined on the class.

// Example:
// Stateless Method Call:
// SomeClass.SomeStatelessMethod();

// Stateful Method Call:
// SomeClass obj = new SomeClass(); // Create an instance of the class.
// obj.SomeStatefulMethod(); // Access the stateful method on the object.

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Whoa, triples?! Impossible! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("Congratulations! You win a new Subaru Mazda Toyta 3505 Hyperspeed Demon!");
}
else if (total >= 10)
{
    Console.WriteLine("Oh yeah, baby! You won a new Azer Legionnaire 4500 Deluxe Laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You scored EXACTLY 7—just the right amount to win a trip to Columbus, Ohio! You go, you!");
}
else
{
    Console.WriteLine("Well, we can't all be winners, can we? Here, have a kitten as a consolation prize. Sure, she's got fleas, three legs, and is blind in both eyes, but she's still cute!");
}