int user2Pass, mainUserPass, tryNumber = 5;
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    mainUserPass = Convert.ToInt32(Console.ReadLine());
}
while (mainUserPass < 0 || mainUserPass > 100);

Console.Clear();
Console.WriteLine("User 2, guess the number.");

do
{
    Console.Write("What is your guess? ");
    user2Pass = Convert.ToInt32(Console.ReadLine());

    if (user2Pass < mainUserPass)
    {
        Console.WriteLine($"{user2Pass} is too low");
    }
    else if (user2Pass > mainUserPass)
    {
        Console.WriteLine($"{user2Pass} is too high");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
    }
    if (tryNumber <= 0)
    {
        Console.WriteLine("YOU LOST ALL OF YOUR CHANCES.");
        user2Pass = mainUserPass;
    }
    else
    {
        Console.WriteLine($"You have left {tryNumber} chances.");
    }
    tryNumber--;
}
while (user2Pass != mainUserPass);
