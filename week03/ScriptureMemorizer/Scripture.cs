using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = scriptureText.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();

        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + "\n" +
               string.Join(" ", displayedWords);
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int count = Math.Min(numberToHide, visibleWords.Count);

        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public int GetHiddenWordCount()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }

    public int GetVisibleWordCount()
    {
        return _words.Count - GetHiddenWordCount();
    }

    public double GetProgressPercentage()
    {
        if (_words.Count == 0)
        {
            return 0;
        }

        return (double)GetHiddenWordCount() / _words.Count * 100;
    }

    public bool IsCompletelyHidden()
    {
        return _words.Count > 0 && GetVisibleWordCount() == 0;
    }
}
