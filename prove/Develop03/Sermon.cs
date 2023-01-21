using System;

class Sermon

{
    private string book, chapter, verse;

    public Sermon (string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
 
    }


     public string makeString()
     {
        return string.Format("{0} {1}:{2}", book, chapter, verse);
     }
     
}