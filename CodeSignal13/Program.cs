using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeSignal13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "foo(bar(baz))blim";
            Program program = new Program();
            program.solution1(inputString);
            string str = inputString;
            while (str.Contains("("))
            {
                str = Regex.Replace(str, @"\(\w*\)", match => {
                    return String.Concat(match.Value.Trim(new[] { '(', ')' }).Reverse());
                });
            }

        }
        string solution1(string str)
        {
            while (str.Contains("("))
            {
                str = Regex.Replace(str, @"\(\w*\)", match => {
                    return String.Concat(match.Value.Trim(new[] { '(', ')' }).Reverse());
                });
            }
            return str;
        }
        public string solution(string inputString)//aveli lav ashxatox versia bayc "sxal" 
        {
            string word = "+";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    for (int j = i + 1; j < inputString.Length; j++)
                    {
                        if (inputString[j] != ')' && inputString[j] != '(')
                            word = word + inputString[j];
                        else
                            break;
                        i = j;
                    }
                }
                if (i != inputString.Length - 1)
                    word = word + "+";
            }

            string[] words = word.Split('+');
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (words[i] != "")
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            string outputString = string.Join("+", words);
            string some = "";
            for (int i = 0; i < outputString.Length; i++)
            {
                if (outputString[i] != '+')
                {
                    some = some + outputString[i];
                }
                else if (inputString[i] != '(' && inputString[i] != ')')
                {
                    some = some + inputString[i];
                }
            }
            Console.WriteLine(some);
            return some;
        }
        public string RemoveInnerBrackets(string inputString)
        {
            int level = 0;
            string outputString = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    level++;
                    if (level == 1) continue;
                }
                else if (inputString[i] == ')')
                {
                    level--;
                    if (level == 0) continue;
                }

                outputString += inputString[i];
            }
            Console.WriteLine(outputString);
            return outputString;
        }
    }

  
}