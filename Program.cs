namespace CS_Intro;

class Program
{
    static void Main(string[] args)
    {
        // we use the string datatype and assign it to a variable called helloWorld
        string helloWorld = "Hello, World!";
        // we use the int datatype (whole numbers) and assign it to the variable myNumber
        int myNumber = 10;
        // double, decimal datatype
        double mySecondNumber = 12.5;
        // bool boolean values
        bool myBool = true;
        // char, single alphanumeric characther
        char a = 'A';

        Console.WriteLine(helloWorld);

        Console.WriteLine(myNumber + mySecondNumber);

        Console.WriteLine(myBool);

        Console.WriteLine(a);

        string message = "Hei ";

        string? name = Console.ReadLine();

        Console.WriteLine(message + name);

    }
}
