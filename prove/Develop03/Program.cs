using System;

class Program
{
    static void Main(string[] args)
    {
        
        Sermon scriptureReference = new Sermon("John", "3", "16-17");
        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world that He gave His only Son, thst whoever believes in Him shall not perish but have eternal life; 17. For God did not send his Son into the world to condemn the world, but to save the world through him.");
        ScriptureReader scriptureReader = new ScriptureReader(scripture);

        string userData = "";

        while (userData != "quit" && scriptureReader.Wordremain() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.makeString(), scriptureReader.makeString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureReader.removeWord();
        }
    }
}