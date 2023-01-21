using System;

class ScriptureReader
{
    private Scripture Scripture;
    

    private List<string> scriptureList;

    public ScriptureReader(Scripture _Scripture)
    {
        Scripture = _Scripture;
        scriptureList = new List<string>();
        convertToList();
    }

    private void convertToList()
    {
        scriptureList = Scripture.makeString().Split(' ').ToList();
    }

    public void removeWord()

    {
        int sumofRemoveWord = new Random().Next(1,2);
        int RemovedWords = 0;
        
        do
        {
            int Rindex = new Random().Next(0, scriptureList.Count());

            if (scriptureList[Rindex].Contains('_') == false)
            {
            scriptureList[Rindex] = new string('_', scriptureList[Rindex].Length);
            RemovedWords++;
            }
        } while (RemovedWords != sumofRemoveWord  );
    }

    public string makeString()
    {
        return string.Join(' ', scriptureList);
    }

    public bool Wordremain()
    {
        bool getval = false;
        foreach (string word in scriptureList)
        {
            if (word.Contains(' ') == false)
            {
                getval =true;
                break;
            }
        }
        return getval;
    }
       

}