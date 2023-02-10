using System;
public class Refrence
{
    private string _book = "";
    private string _chapter = "";
    private string _verse = "";
    private string _endVerse = "";

    public void set_Book(string book)
    {
        this._book = book;
    }

    public string get_Book()
    {
        return _book;
    }

    public void set_Chapter(string chapter)
    {
        this._chapter = chapter;
    }

    public string get_Chapter()
    {
        return _chapter;
    }

    public void set_Verse(string verse)
    {
        this._verse = verse;
    }

    public string get_Verse()
    {
        return _verse;
    }

    public void set_EndVerse(string EndVerse)
    {
        this._endVerse = EndVerse;
    }

    public string get_EndVerse()
    {
        return _endVerse;
    }
}