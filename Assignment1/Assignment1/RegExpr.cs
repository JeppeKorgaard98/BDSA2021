using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            string pattern = @"[A-Za-z0-9]*";
            RegexOptions options = RegexOptions.Multiline;

            foreach(var line in lines)
            {
                foreach(Match m in Regex.Matches(line, pattern, options))
                {
                    if(m.Value != "")
                    {
                        yield return m.Value;
                    }
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            string pattern = @"(?<match1>[0-9]*)x(?<match2>[0-9]*)";
            RegexOptions options = RegexOptions.Multiline;

            foreach(var line in resolutions)   
            {
                foreach(Match m in Regex.Matches(line, pattern, options))
                {
                    int width = Int32.Parse(m.Groups[1].Value);
                    int height = Int32.Parse(m.Groups[2].Value);
                    yield return (width, height);
                }
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            string outerPattern = @"(?<=<" + tag + ")(?:[^>]*>)([\\w\\s\\d<>()/.,]*)(?=</" + tag + ">)";
            Regex regex = new Regex(outerPattern);
            string replacePattern = @"</?[\w\d\s]*>";
            
            foreach (Match match in regex.Matches(html))
            {  
                string result = Regex.Replace(match.Groups[1].Value, replacePattern, "");
                yield return result;
            }
        }
    }
}
