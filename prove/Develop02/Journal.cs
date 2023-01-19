using System;

public class journal
{   
     //List <Entry> answers;
    //public List<Entry> _AllEntries= new List<Entry>();
    public List<Entry> answers;
   // Prompts = prompts;
    
    //string file ="file.txt";

    public  journal()
    {
        answers = new List<Entry>();
       // prompts = new Prompts();

    }   
    //This allows uers to enter answer

   /*public void Writejournal()
   {
      Console.WriteLine("Enter your response here:");
      _response = Console.ReadLine();
      Console.WriteLine($"{_response}");
   }*/
    //This displays the question to users    
    public string GetPrompt()
    {
        Random rand = new Random();
        List<string> question = new List<string>();
        question.Add("What is your Favorite food?");
        question.Add("How often do you read the scriptures?");
        question.Add("When did you give your life to Christ?");
        question.Add("Do you share the gospel with your friends?");
        question.Add("What is one mistake you won't do again?");

        int first = rand.Next(0,4);
        return question[first];   

        
    }
    //Date function    
    /*public void TheDate()
    {
        Console.WriteLine("Date:");
        _date = Console.ReadLine();
        Console.WriteLine($"Date: {_date}");
    }
    */
    public void TheEntries()
    {   
        Console.WriteLine("Type here: ");
        string response = Console.ReadLine();
        string file = "file.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(response);
        }
    }

    //Add entries to List
    public void AddToEntries()
    {
        string prompts = GetPrompt();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(prompts);
        String theResponse = Console.ReadLine();
        Entry  UserAnswer = new Entry(theResponse, prompts, date);
        answers.Add(UserAnswer);

    }

    public void ShowList()
    {
        foreach (Entry UserAnswer in answers)
        {
            Console.WriteLine($"Date: {UserAnswer._date} - Prompts: {UserAnswer._prompt}\n - {UserAnswer._response}");
        }
    }

    public void Load(string file)
    {
        using (StreamReader read = new StreamReader(file))
        {
            string SavedAnswer = read.ReadToEnd();
            Console.WriteLine("\n" +SavedAnswer);
        }
    }


    public void save(string file)
    {
        using (StreamWriter SavedAnswer = new StreamWriter(file) )
        {
            foreach (Entry UserAnswer in answers)
            {
                SavedAnswer.WriteLine($"Date: {UserAnswer._date} - Prompts: {UserAnswer._prompt}\n - {UserAnswer._response}");
            }
        }
    }

}