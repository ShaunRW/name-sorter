using System;
using Xunit;
using name_sorter;

namespace name_sorter.Tests
{
    public class SorterTests
    {
        [Fact]
        public void Sorter_AddNameList_GetNameListTest()
        {
            // init the sorter
            Sorter mySorter = new Sorter();

            // Create the input name list
            string[] nameList = { "abc abc", "xyz abc", "abc xyz" };

            // add the name list to the sorter
            mySorter.AddNameList( nameList );

            // get the name list in the sorter without performing the sort operation.
            string[] result = mySorter.GetNameList();

            // if the input and the result are equal both methods worked.
            Assert.Equal( nameList, result );

        }

        [Fact]
        public void Sorter_SortNamesSortsCorrectly()
        {
            // init the sorter
            Sorter mySorter = new Sorter();

            // create the input name list and the expected result name list
            string[] nameList = { "xyz abc", "abc abc", "abc xyz" };
            string[] expectedResult = { "abc abc", "xyz abc", "abc xyz" };

            // add the input name list to the sorter and perform the sort.
            mySorter.AddNameList( nameList );
            mySorter.SortNames();

            // get the new sorted name list.
            string[] result = mySorter.GetNameList();

            // validate the result.
            Assert.Equal( expectedResult, result );

        }

    }
}
