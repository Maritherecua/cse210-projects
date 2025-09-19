using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
// This program stores and displays a scripture both by reference and text.
// It allows the user to hide (replacing individual letters by underscores) random words in the scripture until all words are hidden or the user decides to quit.
// It clears the console screen, and displays the scripture again. Ends when all words are hidden or the user types "quit".
// Shows the final display of the scripture with all words hidden.
// It uses classes Scripture, Reference, and Word to achieve this functionality.
// Prompt the user to press Enter to hide a word or type 'quit' to exit the program.
// it randomly selects a word that is not already hidden and replaces it with underscores.
// it uses the principle of encapsulation by keeping the data (words and their hidden status) private within the Scripture class
// and providing public methods to interact with that data.
//provides multiple constructors for flexibility in creating Scripture objects,
// including one that accepts a full reference string and another that accepts individual components (verse range, verse).
// loads scripture text from an external file, allowing for easy updates and additions to the scripture
// database without modifying the code.
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}