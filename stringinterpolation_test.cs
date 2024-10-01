namespace stringInterPolationTest;
class stringInterPolationTest
{
    static void Curiosa(string[] args)
    {
        Console.WriteLine("Hello, World!");


// Ta imot spørsmål, og bruk input videre
        string stateName = "Hva er ditt navn?";
        Console.WriteLine(stateName);
        string? name = Console.ReadLine();

        // Hilser brukeren
        string welcomeMessage = $"Hei {name}, velkommen til denne demonstrasjonen av C#.";
        Console.WriteLine(welcomeMessage);

        // Spør bruker om alder
        string askAge = $"Hva er din alder, {name}?";
        Console.WriteLine(askAge);

        // Les inn aldersinput
        string? ageInput = Console.ReadLine();

        // Valider input
        if (int.TryParse(ageInput, out int age))
        {
            // Kontroller: Hvis input er gyldig (et heltall), skriv ut alderen
            Console.WriteLine($"{name}, du er {age} år. Det er en glimrende alder til å begynne å lære C#!");
        }
        else
        {
            // Kontroller: Hvis input er ugyldig, gi en beskjed
            Console.WriteLine($"Ugyldig input {name}, ditt fjols. Du må skrive inn alderen som et tall.");
        }

        // Programmet avsluttes etter valideringen
    }}
