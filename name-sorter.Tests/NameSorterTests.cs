using System;
using System.Collections.Generic;
using Xunit;
using name_sorter;

namespace name_sorter.Tests
{
    public class NameSorterTests
    {
        [Fact]
        public void PersonNameConverter_PerformSortCorrectly( )
        {

            PersonNameConverter converter = new PersonNameConverter();
            NameSorter sorter = new NameSorter();

            // Define the test input and expected result
            string[] rawNames = { "Homer Jay Simpson", "Bart Simpson", "Ned Flanders", "Milhouse Van Houten" };
            string[] expectedResult = { "Ned Flanders", "Milhouse Van Houten", "Bart Simpson", "Homer Jay Simpson" };

            // create the list of PersonNames to sort
            List<PersonName> personNames = converter.StringArrayToPersonNameList( rawNames );

            // perfome the operation that is being tested. The sort operation.
            personNames = sorter.SortByLastNameThenFirstName( personNames );

            // if the input and the result are equal both methods worked.
            Assert.Equal( expectedResult, converter.PersonNameListToStringArray(personNames) );
        }

    }
}
