using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_returns_all_elements_in_list_of_lists()
        {
            var list = new List<int>() {1, 2, 3, 4, 5};   
            var list1 = new List<int>() {6, 7, 8, 9, 10};   
            var listOfLists = new List<List<int>>() {list, list1};

            var actual = Iterators.Flatten(listOfLists);
            var expected = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};   

            Assert.Equal(expected, actual);
        } 
    }
}
