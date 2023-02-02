

using System.Linq;
using System.Reflection.PortableExecutable;

Console.WriteLine("Please enter a word");
string input = Console.ReadLine();
Console.WriteLine(ReverseInput(input));












//method 
  static string ReverseInput(string input)
{
    Stack<char> stack = new Stack<char>();
      foreach(char s in input)
    {
        stack.Push(s); 
    }
    string result = "";
    foreach(char c in stack)
    {
        result += c;
    }
    return result;
}
    




    //foreach(char c in string.Join(",", stack.ToArray()))
    //{
    //    stack .Pop();
    //}


