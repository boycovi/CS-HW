bool guessed = false;
Random random = new Random();
byte num = (byte)random.Next(1, 146);

while (!guessed)
{
    Console.WriteLine("Guess the number between 1 and 146");
    var x = Console.ReadLine();
    int.TryParse(x, out int guess);
    if (guess > num) Console.WriteLine("Less");
    if (guess < num) Console.WriteLine("Greater");
    else
    {
        Console.WriteLine("You guessed it!");
        guessed = true;
    }
}
Environment.Exit(0);