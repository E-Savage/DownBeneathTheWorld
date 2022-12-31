// See https://aka.ms/new-console-template for more information

/*
 * Tomb -- Jungle
 *            |
 *          Swamp -- Cave -- Underworld
 */

using gameV01;

Room room0 = new Room("Tomb", "You wake up and there is a dusty stone sarcophagus in the corner and the lid has been moved off of it. There is a corridor in front of you.",
    -1, -1, -1, 1);
Room room1 = new Room("Jungle", "You have walked into a lively jungle. You can hear birds and other little creatures.",
    -1, 2, -1, 1);
Room room2 = new Room("Swamp","you seem to have wandered into a dank smelling swamp.",
    1, -1, -1, 3);
Room room3 = new Room("Cave", "After walking in here you realize there was a danker smelling place.",
    -1, -1, 2, 4);
Room room4 = new Room("Underworld", "You have wandered into a fiery place. It does not seem inviting...",
    -1, -1, 3, -1);

Room[] map = {room0, room1, room2, room3, room4};

bool isRunning = true;
int position = 0;
int newPos = 0;

while (isRunning)
{
    printBanner();
    getLocation();
}

void printBanner()
{
    Console.WriteLine($"Location: {map[position].name}");
    Console.WriteLine($"Description: {map[position].description}");
}

void getLocation()
{
    Console.WriteLine("Would you like to go North, South, West or East?" +
        "\nN)orth" +
        "\nS)outh" +
        "\nW)est" +
        "\nE)ast" +
        "\nQ)uit");
    string direction = Console.ReadLine().ToLower().Trim();
    char dir = direction[0];
    switch (dir)
    {
        case 'n':
            newPos = map[position].n;
            break;
        case 's':
            newPos = map[position].s;
            break;
        case 'w':
            newPos = map[position].w;
            break;
        case 'e':
            newPos = map[position].e;
            break;
        case 'q':
            Console.WriteLine("Thanks for playing\n" +
                "enter anyhting to quit");
            Console.Write(">>> ");
            Console.ReadLine();
            break;
    }

    if (newPos == -1)
    {
        Console.WriteLine("There is no exit this way");
    }
    else
    {
        position = newPos;
    }
}
