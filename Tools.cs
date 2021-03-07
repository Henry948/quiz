using System;
using System.IO;

namespace Quiz
{
  public class Tools
  {
    public static void SetUpInputStream(string sample)
    {
        if (sample == null)
        {
            Console.SetIn(new StreamReader("true.txt"));
        }      
    }
  }
}