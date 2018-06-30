using System;
using System.Collections.Generic;
namespace CountingWords
{
  public class RepeatCounter
  {
  //  private int _total = 0;
    private string _word;
    private string _newWord;
  //private int _total;
    public RepeatCounter(string word, string newWord)
    {
      _word = word;
      _newWord = newWord;
      //_total= 0;
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
      int  _total = 0;
      //string _newString = " ";

      if(_word != " ")
      {
      try
      {
        string[] stringArray=_newWord.Split(' ');
        for(int i=0; i<stringArray.Length; i++)
        {
          if(_word.ToLower() == stringArray[i].ToLower())
          {
            _total++;
          }
        }
      }
      catch ( InvalidCastException )
      {
    Console.WriteLine("That is not good enough");
  }
    }
      return _total;
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
