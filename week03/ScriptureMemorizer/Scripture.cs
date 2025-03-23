using System;

public class Scripture()
{
    private string _refrence;
    private List<Word> _verses; 

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_verses.Count);
        _verses[index].Hide();
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach(Word word in _verses)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool IsCompletelyHidden(bool isHidden)
    {
        foreach(Word word in _verses)
        {
            if(!word.isHidden(isHidden))
            {
                return false;
            }
        }
        return true;
    }
}