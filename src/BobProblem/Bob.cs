using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BobProblem
{
    public class Bob
    {
        private string RemoveAllWhiteSpace(string statement)
        {
            var result = statement.TrimStart().TrimEnd();
            result = Regex.Replace(result, @"\s+", "");
            result = Regex.Replace(result, "\b", "");
            return result;
        }


        private bool IsAQuestion(string statement)
        {
            return statement.EndsWith("?");
        }

        private bool HasQuestionMark(string statement)
        {
            return statement.Contains("?");
        }

        private bool IsEmptyStatement(string statement)
        {
            return string.IsNullOrWhiteSpace(statement);
        }

        private bool IsYellingAtHim(string statement)
        {
            //TODO: should be in capitals and special character
            var regex = new Regex(@"[A-Z][a-z]?\d*");

            return regex.IsMatch(statement);
        }

        public string hey(string message)
        {
            message = RemoveAllWhiteSpace(message);

            if (IsEmptyStatement(message))
                return "Fine. Be that way!";

            if (IsYellingAtHim(message))
            {
                if (IsAQuestion(message))
                    return "Calm down, I know what I'm doing!";

                return "Whoa, chill out!";
            }

            if (IsAQuestion(message))
            {
                return "Sure.";
            }

            if (HasQuestionMark(message))
            {
                return "Whoa, chill out!";
            }

            return "Whatever.";
        }
    }
}
