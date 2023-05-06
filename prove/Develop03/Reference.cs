using System;

class Reference
{
    private string book, chapter, begVerse, endVerse;

    public Reference (string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        begVerse = _verse;
        endVerse = "";
    }

    public Reference (string _book, string _chapter, string _begverse, string _endVerse)
    {
        book = _book;
        chapter = _chapter;
        begVerse = _begverse;
        endVerse = _endVerse;

    }

    public string DisplayReference()
    {
        if (endVerse == "")
        {
            return($"{book} {chapter}:{begVerse}");
        }
        else
        {
            return($"{book} {chapter}:{begVerse}-{endVerse}");
        }
    }
}