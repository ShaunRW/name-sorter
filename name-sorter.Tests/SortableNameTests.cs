using System;
using Xunit;
using name_sorter;

namespace name_sorter.Tests
{
    public class SortableNameTests
    {
        // This will test whether the sortable name will automatically create the sort string in the correct format.
        [Theory]
        [InlineData( "one two", "two one" )]
        [InlineData( "one two three", "three one two" )]
        [InlineData( "one two three four", "four one two three" )]
        public void SortableName_SortStringCreatedCorrectly( string fullName, string expectedResult )
        {
            SortableName name = new SortableName( fullName );
            Assert.Equal( expectedResult, name.sortString );
        }

        // this will test whether the sortable name will automaically remove white space at the end of the name string.
        [Theory]
        [InlineData( "one two ", "one two" )]
        public void SortableName_RemovesTrailingWhitespace( string fullName, string expectedResult )
        {
            SortableName name = new SortableName( fullName );
            Assert.Equal( expectedResult, name.originalString );

        }
        
    }
}
