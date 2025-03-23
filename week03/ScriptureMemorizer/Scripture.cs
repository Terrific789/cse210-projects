using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _verses; 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _verses = text.Split(' ').Select(word => new Word(word)).ToList();
    }

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
            if(!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}