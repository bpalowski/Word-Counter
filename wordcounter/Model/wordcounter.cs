using System;
using System.Collections.Generic;
namespace WordCounter
{
  public class RepeatCounter
  {
    private string _word;
    private string _newWord;
    public RepeatCounter(string word, string newWord)
    {
      _word = word;
      _newWord = newWord;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetString()
    {
      return _newWord;
    }
    public int WordTotal()
    {
      int _counter = 0;
      //string _newString = " ";
      if (_word != " ")
      {
        string[] stringArray=_newWord.Split(' ');
        for(int i=0; i<stringArray.Length; i++)
        {
          if(_word.ToLower() == stringArray[i].ToLower())
          {
            _counter++;
          }
        }
      }
      return _counter;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a single letter:");
      string singleWord = Console.ReadLine();
      Console.WriteLine("Input in a word ");
      string wordConjoined = Console.ReadLine();
      RepeatCounter newWord = new RepeatCounter(singleWord, wordConjoined);
      Console.WriteLine("This is how many times your single letter appeared:" + newWord.WordTotal());
    }
  }
}
