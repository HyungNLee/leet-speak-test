using System;


namespace Leet
{
  public class LeetSpeak
  {
    public string ConvertToLeetSpeak(string input)
    {
      string leetString = "";
      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == 'e' || input[i] == 'E')
        {
          leetString += "3";
        }
        else if (input[i] == 'o' || input[i] == 'O')
        {
          leetString += "0";
        }
        else if (input[i] == 'I')
        {
          leetString += "1";
        }
        else if (input[i] == 't' || input[i] == 'T')
        {
          leetString += "7";
        }
        else if (i != 0 && input[i] == 's' || input[i] == 'S')
        {
          leetString += "z";
        }
        else
        {
          leetString += input[i];
        }
      }
      return leetString;
    }
  }
}
