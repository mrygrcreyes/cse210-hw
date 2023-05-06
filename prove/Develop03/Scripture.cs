using System;

class Scripture
{
    private List<Word> words;
    private Reference scriptureReference;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        words = new List<Word>();
        CreateWordsList(_scriptureText);

    }

    private void CreateWordsList(string _scriptureText)
    {
        List<string> allWords = _scriptureText.Split(" ").ToList();
        foreach (string item in allWords)
        {
            Word word = new Word(item);
            words.Add(word);
        }
    }

    public string DisplayScripture()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.DisplayWord() + " "; 
            }
            else
            {
                scriptureText += new string('_', word.DisplayWord().Length) + " ";

            }
        }
        return ($"{scriptureReference.DisplayReference()} {scriptureText}");

    }

    public bool CheckHiddenWords()
    {
        bool retValue = false;
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                retValue = true;
            }
        }
        return retValue;

    }

    public void HiddenWords()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0,words.Count());

            if (words[rndIndex].GetIsHidden() == false)
            {
            words[rndIndex].SetIsHidden(true);
            wordsRemoved++;
    
            }
        }while (wordsRemoved != numWordsToRemove && CheckHiddenWords() == true); 

    }

}