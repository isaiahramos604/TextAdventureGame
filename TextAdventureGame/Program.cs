using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");
        Console.WriteLine("You find yourself in a mysterious mansion...");

        // Initialize player's starting position
        int currentRoom = 1;

        while (true)
        {
            Console.WriteLine(GetRoomDescription(currentRoom));

            // Display available choices
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Go North");
            Console.WriteLine("2. Go South");
            Console.WriteLine("3. Go East");
            Console.WriteLine("4. Go West");
            Console.WriteLine("5. Quit");

            // Get player's choice
            int choice = GetChoice(1, 5);

            // Process player's choice
            if (choice == 5)
            {
                Console.WriteLine("Thank you for playing! Goodbye!");
                break;
            }

            currentRoom = Move(currentRoom, choice);
        }
    }

    static string GetRoomDescription(int room)
    {
        switch (room)
        {
            case 1:
                return "You are in the foyer. There are stairs leading up.";
            case 2:
                return "You are in the living room. There's a fireplace and a cozy sofa.";
            case 3:
                return "You are in the kitchen. You smell something delicious cooking.";
            case 4:
                return "You are in the bedroom. There's a large canopy bed.";
            case 5:
                return "You are in the bathroom. There's a bathtub and a mirror.";
            default:
                return "You are in a mysterious place.";
        }
    }

    static int GetChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= min && choice <= max)
                    break;
            }
            Console.WriteLine("Invalid choice. Please try again.");
        }
        return choice;
    }

    static int Move(int currentRoom, int direction)
    {
        switch (direction)
        {
            case 1: // North
                if (currentRoom == 1)
                    return 2;
                else if (currentRoom == 2)
                    return 3;
                else
                {
                    Console.WriteLine("You can't go that way.");
                    return currentRoom;
                }
            case 2: // South
                if (currentRoom == 3)
                    return 2;
                else if (currentRoom == 2)
                    return 1;
                else
                {
                    Console.WriteLine("You can't go that way.");
                    return currentRoom;
                }
            case 3: // East
                if (currentRoom == 2)
                    return 4;
                else if (currentRoom == 4)
                    return 5;
                else
                {
                    Console.WriteLine("You can't go that way.");
                    return currentRoom;
                }
            case 4: // West
                if (currentRoom == 5)
                    return 4;
                else if (currentRoom == 4)
                    return 2;
                else
                {
                    Console.WriteLine("You can't go that way.");
                    return currentRoom;
                }
            default:
                return currentRoom;
        }
    }
}