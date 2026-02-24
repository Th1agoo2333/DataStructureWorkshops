bool continueProgram = true;

while (continueProgram)
{
    Console.Write("Enter the beam: ");
    string viga = Console.ReadLine() ?? "";

    // Validate empty input
    if (string.IsNullOrEmpty(viga))
    {
        Console.WriteLine("The beam is incorrectly built!");
    }
    else
    {
        int resistenciaBase = 0;

        // Validate base
        char baseViga = viga[0];

        if (baseViga == '%')
        {
            resistenciaBase = 10;
        }
        else if (baseViga == '&')
        {
            resistenciaBase = 30;
        }
        else if (baseViga == '#')
        {
            resistenciaBase = 90;
        }
        else
        {
            Console.WriteLine("The beam is incorrectly built!");
            AskToContinue();
            continue;
        }

        int pesoTotal = 0;
        int contadorLargueros = 0;
        bool malConstruida = false;

        // Traverse the beam structure
        for (int i = 1; i < viga.Length; i++)
        {
            char actual = viga[i];

            // Validate allowed characters
            if (actual != '=' && actual != '*')
            {
                malConstruida = true;
                break;
            }

            // Detect two consecutive connections
            if (actual == '*' && viga[i - 1] == '*')
            {
                malConstruida = true;
                break;
            }

            if (actual == '=')
            {
                contadorLargueros++;
                pesoTotal += contadorLargueros;
            }
            else if (actual == '*')
            {
                if (contadorLargueros == 0)
                {
                    malConstruida = true;
                    break;
                }

                int pesoConexion = contadorLargueros * 2;
                pesoTotal += pesoConexion;

                contadorLargueros = 0;
            }
        }

        // Final validation
        if (malConstruida)
        {
            Console.WriteLine("The beam is incorrectly built!");
        }
        else
        {
            if (pesoTotal <= resistenciaBase)
            {
                Console.WriteLine("The beam supports the weight!");
            }
            else
            {
                Console.WriteLine("The beam does NOT support the weight!");
            }
        }
    }

    continueProgram = AskToContinue();
}


// Function to ask if the user wants to continue
bool AskToContinue()
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