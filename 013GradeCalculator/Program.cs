int points = 0;
int maxPoints = 0;
double calculation = 0;

{
    {
        Console.WriteLine("Did you participate in the first written exam? Please type Yes (1) or No (2) !");
        int question = int.Parse(Console.ReadLine()!);

        if (question == 1)
        {
            Console.Write("How many points did you had in the first written exam (0-20): ");
            points += int.Parse(Console.ReadLine()!);
            maxPoints += 20;
        }
        else
        {
            Console.WriteLine("Okay!");
        }
    }

    {
        Console.WriteLine("Did you participate in the second written exam? Please type Yes (1) or No (2) !");
        int question = int.Parse(Console.ReadLine()!);

        if (question == 1)
        {
            Console.Write("How many points did you had in the second written exam (0-20): ");
            points += int.Parse(Console.ReadLine()!);
            maxPoints += 40;
        }
        else
        {
            Console.WriteLine("Okay!");
        }
    }
}




calculation = (points + points) / maxPoints * 100;


    if (calculation >= 89)
{
    Console.WriteLine("Congratulations you have a 1!");
}

else if (calculation >= 76)
{
    Console.WriteLine("Congratulations you have a 2!");
}

else if (calculation >= 63)
{
    Console.WriteLine("Good job you have a 3!");
}

else if (calculation >= 50)
{
    Console.WriteLine("Next time will be better you have a 4. ");
}

else if (calculation >= 0)
{
    Console.WriteLine("Bad you have a 5");
}

else
{
    Console.WriteLine("Sorry you failed...");
}

Console.WriteLine("Press any key to exit: ");
Console.ReadKey();
Console.Clear();
