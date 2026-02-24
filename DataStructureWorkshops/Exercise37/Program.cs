bool continueKnights = true;

while (continueKnights)
{
    Console.Write("Enter knight positions (example: B7,C5,E2,H7,G5,F6): ");
    string input = Console.ReadLine() ?? "";

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("No positions entered.");
        continueKnights = AskToContinue();
        continue;
    }

    string[] positions = input.Split(',');

    int[] rows = new int[positions.Length];
    int[] cols = new int[positions.Length];

    // Convert positions to numeric coordinates
    for (int i = 0; i < positions.Length; i++)
    {
        string pos = positions[i].Trim().ToUpper();

        if (pos.Length != 2)
        {
            Console.WriteLine("Invalid position format.");
            continueKnights = AskToContinue();
            goto EndLoop;
        }

        char columnLetter = pos[0];
        char rowNumber = pos[1];

        cols[i] = columnLetter - 'A' + 1;
        rows[i] = rowNumber - '0';
    }

    // Analyze each knight
    for (int i = 0; i < positions.Length; i++)
    {
        Console.Write("Analyzing Knight at " + positions[i].ToUpper() + " => ");

        bool hasConflict = false;

        for (int j = 0; j < positions.Length; j++)
        {
            if (i == j)
                continue;

            int rowDiff = Math.Abs(rows[i] - rows[j]);
            int colDiff = Math.Abs(cols[i] - cols[j]);

            if ((rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2))
            {
                Console.Write("Conflict with " + positions[j].ToUpper() + " ");
                hasConflict = true;
            }
        }

        if (!hasConflict)
        {
            Console.Write("No conflict");
        }

        Console.WriteLine();
    }

EndLoop:
    continueKnights = AskToContinue();
}

static bool AskToContinue()
{
    while (true)
    {
        Console.Write("Do you want to continue? (Y/N): ");
        string response = Console.ReadLine() ?? "";

        if (response.ToUpper() == "Y")
        {
            Console.WriteLine();
            return true;
        }
        else if (response.ToUpper() == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid option. Please enter Y or N.");
        }
    }
}