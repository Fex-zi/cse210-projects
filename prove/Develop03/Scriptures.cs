using System;

class Scripture
{
    private string scriptureWord;

    private Sermon scriptureReference;      


    public Scripture (Sermon _scriptureReference, string _scriptureWord)
    {
        scriptureWord = _scriptureWord;
        scriptureReference = _scriptureReference;
    }

     public string makeString()
     {
        return string.Format("{0}", scriptureWord );
     }
     

    

}
