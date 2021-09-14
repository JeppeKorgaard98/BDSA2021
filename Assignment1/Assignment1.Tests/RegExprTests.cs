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

    }
}
