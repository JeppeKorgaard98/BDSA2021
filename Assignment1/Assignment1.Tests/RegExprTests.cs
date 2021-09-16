using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Splitline_seprates_strings_on_space_and_special_characters()
        {
            var listOfStrings = new List<string>() {"Hello my friend", "how%are#you"};

            var expected = new List<string>() {"Hello", "my", "friend", "how", "are", "you"};
            var actual = RegExpr.SplitLine(listOfStrings);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Resolution_collects_tuples()
        {
            var inputList = new List<string>() {"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};

            var expected = new List<(int,int)>() {(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};
            var actual = RegExpr.Resolution(inputList);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InnerText_returns_text_within_tag()
        {
            string input = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
            string tag = "a";

            var expected = new List<string>() {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};
            var actual = RegExpr.InnerText(input,tag);

            Assert.Equal(expected, actual);

            string input1 = "<div>  <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> </div>";
            string tag1 = "p";

            var expected1 = new List<string>() {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};
            var actual1 = RegExpr.InnerText(input1,tag1);

            Assert.Equal(expected1, actual1);
        }
    }
}
