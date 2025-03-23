using System;
using System.Security.Principal;

public class Refrence
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public string GetDisplayText(string book, int chapter, int verse, int endVerse){
        // Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");

        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    public void SetBook(string book){
        _book = book;
    }

    public void SetChapter(int chapter){
        _chapter = chapter;
    }

    public void SetVerse(int verse){
        _verse = verse;
    }

    public void SetEndVerse(int endVerse){
        _endVerse = endVerse;
    }

    public string GetBook(){
        return _book;
    }

    public int GetChapter(){
        return _chapter;
    }

    public int GetVerse(){
        return _verse;
    }

    public int GetEndVerse(){
        return _endVerse;
    }
} 