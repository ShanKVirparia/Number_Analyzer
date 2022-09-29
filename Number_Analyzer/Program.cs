Console.WriteLine("Welcome to the Number Analyzer!");

//Asking Name
Console.WriteLine("What is your name?");
var name = Convert.ToString(Console.ReadLine());

while (true)
{
    //Number 1 through 100
    Console.WriteLine($"{name} input a number between 1 through 100: ");
    var inputNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    //Validation of the number entered
    // This an example of nested if statements that can help determine the correct response (LM Response)
    if (inputNumber >= 1 && inputNumber <= 100)
    {
        if (inputNumber % 2 != 0 && inputNumber < 60)
        {
            Console.WriteLine($"{name}, the number you entered is odd and less than 60.");

        }
        else if (inputNumber % 2 == 0 && inputNumber > 1 && inputNumber < 25)
        {
            Console.WriteLine($"{name}, the number you entered is even and less than 25.");

        }
        else if (inputNumber % 2 == 0 && inputNumber > 25 && inputNumber < 61)
        {
            Console.WriteLine($"{name}, the number you entered is even and between 26 and 60 inclusive.");

        }
        else if (inputNumber % 2 == 0 && inputNumber > 60)
        {
            Console.WriteLine($"{name}, the number you entered is even and greater than 60.");

        }
        else if (inputNumber % 2 != 0 && inputNumber > 60)
        {
            Console.WriteLine($"{name}, the number you entered is odd and greater than 60.");

        }
    }
    else if (inputNumber < 1 || inputNumber > 100)
    {
        Console.WriteLine($"{name}, number the must be between 1 and 100.");
        var newInputNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if (newInputNumber > 1 && newInputNumber < 100)
        {
            if (newInputNumber % 2 != 0 && newInputNumber < 60)
            {
                Console.WriteLine($"{name}, the number you entered is odd and less than 60.");

            }
            else if (newInputNumber % 2 == 0 && newInputNumber > 1 && newInputNumber < 25)
            {
                Console.WriteLine($"{name}, the number you entered is even and less than 25.");

            }
            else if (newInputNumber % 2 == 0 && newInputNumber > 25 && newInputNumber < 61)
            {
                Console.WriteLine($"{name}, the number you entered is even and between 26 and 60 inclusive.");

            }
            else if (newInputNumber % 2 == 0 && newInputNumber > 60)
            {
                Console.WriteLine($"{name}, the number you entered is even and greater than 60.");

            }
            else if (newInputNumber % 2 != 0 && newInputNumber > 60)
            {
                Console.WriteLine($"{name}, the number you entered is odd and greater than 60.");

            }
        }
    }

    Console.WriteLine("Do you want to analyze another number? (yes or no)");
    var analyzeAnotherNumber = Convert.ToString(Console.ReadLine());

    if (analyzeAnotherNumber.ToLower() == "yes")
    {
        continue;
    }
    else if (analyzeAnotherNumber.ToLower() == "no")
    {
        break;
    }
}