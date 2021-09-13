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

        [Fact]
        public void Filter_return_even_numbers()
        {
            var list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Predicate<int> isEven = Even;

            var actual = Iterators.Filter(list, isEven);
            var expected = new List<int>() {2, 4, 6, 8, 10};

            Assert.Equal(expected, actual);


            bool Even(int i)
            {
                return i % 2 == 0;
            }
        }
    }
}
