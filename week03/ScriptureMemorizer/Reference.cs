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

class Reference
{
    private string _book;
    private string _chapter;
    private string _verseRange;

    public Reference(string referenceStr)
    {                                // Example formats: "John 3:16", "1 Nephi 3", "Alma 32:21-23"
                                //Represents text as a sequence of UTF-16 code units.
        var match = Regex.Match(referenceStr, @"^(.*?)\s+(\d+)(?::(\d+(-\d+)?))?$");
        if (match.Success)
        {
            _book = match.Groups[1].Value;
            _chapter = match.Groups[2].Value;
            _verseRange = match.Groups[3].Success ? match.Groups[3].Value : "";
        }
        else
        {
            throw new ArgumentException("Invalid reference format.");
        }
    }

    public Reference(string book, string chapter, string verseRange)
    {
        _book = book;
        _chapter = chapter;
        _verseRange = verseRange;
    }

    public string GetDisplayText()
    {
        return string.IsNullOrEmpty(_verseRange) ? $"{_book} {_chapter}" : $"{_book} {_chapter}:{_verseRange}";
    }
}       
