//Declarations

int win = 0;
int draw = 0;
int loss = 0;
int input;
bool keepGoing = true;

Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
Console.WriteLine("To Play, enter the number corresponding to the item you want to pick!\n\nIf you want to Quit at any point, press 9\n");

while (keepGoing)
{
    Console.WriteLine("1. Rock   2. Paper   3. Scissors 4. Lizard 5. Spock\n");
    input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Rock();
            break;

        case 2:
            Paper();
            break;

        case 3:
            Scissors();
            break;

        case 4:
            Lizard();
            break;

        case 5:
            Spock();
            break;

        case 9:
            keepGoing = false;
            break;

        default:
            Console.WriteLine("Invalid Selection");
            break;
    }


    void Rock()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        Console.WriteLine("\nYou Chose ROCK!");

        if (number == 1)
        {
            Console.WriteLine("\nI Choose Rock, DRAW!\n");
            draw += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nPaper Cover Rock, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nRock Crushes Scissors, YOU WIN!\n");
            win += 1;
        }
        else if (number == 4)
        {
            Console.WriteLine("\nRock Crushes Lizard, YOU WIN!\n");
            win += 1;
        }
        else if (number == 5)
        {
            Console.WriteLine("\nSpock Vaporizes Rock, YOU LOSE!\n");
            loss += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Paper()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        Console.WriteLine("\nYou Chose PAPER!");

        if (number == 1)
        {
            Console.WriteLine("\nPaper Covers Rock, YOU WIN!\n");
            win += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nI Choose Paper, DRAW!\n");
            draw += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nScissors Cuts Paper, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 4)
        {
            Console.WriteLine("\nLizard Eats Paper, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 5)
        {
            Console.WriteLine("\nPaper Disproves Spock, YOU WIN!\n");
            win += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Scissors()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        Console.WriteLine("\nYou Chose SCISSORS!");

        if (number == 1)
        {
            Console.WriteLine("\nRock Crushes Scissors, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nScissors Cuts Paper, YOU WIN!\n");
            win += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nI Choose Scissors, DRAW!\n");
            draw += 1;
        }
        else if (number == 4)
        {
            Console.WriteLine("\nScissors Decapitates Lizard, YOU WIN!\n");
            win += 1;
        }
        else if (number == 5)
        {
            Console.WriteLine("\nSpock Smashes Scissors, YOU LOSE!\n");
            loss += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Lizard()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        Console.WriteLine("\nYou Chose LIZARD!");

        if (number == 1)
        {
            Console.WriteLine("\nRock Crushes Lizard, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nLizard Eats Paper, YOU WIN!\n");
            win += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nScissors Decapitates Lizard, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 4)
        {
            Console.WriteLine("\nI choose Lizard, DRAW!\n");
            draw += 1;
        }
        else if (number == 5)
        {
            Console.WriteLine("\nLizard Poisons Spock!, YOU WIN!\n");
            win += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Spock()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        Console.WriteLine("\nYou Chose SPOCK!");

        if (number == 1)
        {
            Console.WriteLine("\nSpock Vaporizes Rock, YOU WIN!\n");
            win += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nPaper Disproves Spock, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nSpock Smashes Scissors, YOU WIN!\n");
            win += 1;
        }
        else if (number == 4)
        {
            Console.WriteLine("\nLizard Poisons Spock, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 5)
        {
            Console.WriteLine("\nI Choose Spock, DRAW!\n");
            draw += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }
}