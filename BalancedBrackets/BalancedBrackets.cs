using System;
using System.Text.RegularExpressions;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            int openBrackets = 0;
            int closeBrackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[')
                {
                    openBrackets++;
                }
                else if (ch == ']')
                {
                    closeBrackets++;
                }
            }
            if (openBrackets != closeBrackets)
            {
                return false;
            }
            else
            {
                if (openBrackets == 0)
                {
                    return true;
                }
                char[] strArray = str.ToCharArray();
                for (int i = 0; i < openBrackets; i++)
                {
                    int indexOpen = Array.IndexOf(strArray, '[');
                    int indexClose = Array.IndexOf(strArray, ']');
                    if (indexOpen > indexClose)
                    {
                        return false;
                    }
                    for(int j = indexOpen; j < indexClose; j++)
                    {
                        if (strArray[j+1] == '[')
                        {
                            return false;
                        }
                    }
                    strArray[indexOpen] = 'm';
                    strArray[indexClose] = 'm';
                }
                return true;
                

                /*
                string pattern = @"\[[^\[]*\]";
                var expression = new Regex(pattern);
                MatchCollection matches = expression.Matches(str);
                return matches.Count == closeBrackets;
                */
            }
            
            
        }
    }
}
