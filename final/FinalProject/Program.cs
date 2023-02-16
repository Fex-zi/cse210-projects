using System;


class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        UserInput input = new UserInput();
        UserChoice choice = new UserChoice(input, library);
        UserOutput output = new UserOutput();

        choice.Start(output);
    }
}
