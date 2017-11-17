using System;
using Xunit;
using name_sorter;

namespace name_sorter.Tests
{
    public class PersonNameConverterTests
    {
        [Theory]
        [InlineData( "Bart", "Simpson" )]
        [InlineData( "Homer Jay", "Simpson" )]
        public void PersonNameConverter_ConvertsToPersonNameCorrectly( string givenNames, string lastName )
        {
            // init the objects
            PersonNameConverter converter = new PersonNameConverter();
            PersonName personName = new PersonName();

            // perform the operation that is being tested.
            personName = converter.StringToPersonName( givenNames + ' ' + lastName );

            // if the input and the result are equal both methods worked.
            Assert.Equal( personName.givenNames, givenNames );
            Assert.Equal( personName.lastName, lastName );
        }

        [Theory]
        [InlineData( "Bart", "Simpson", "Bart Simpson" )]
        [InlineData( "Homer Jay", "Simpson", "Homer Jay Simpson" )]
        public void PersonNameConverter_ConvertsToRawStringCorrectly( string givenNames, string lastName, string expected )
        {
            // init the objects
            PersonNameConverter converter = new PersonNameConverter();
            PersonName personName = new PersonName();

            // perform the operation that is being tested.
            personName.givenNames = givenNames;
            personName.lastName = lastName;

            // if the input and the result are equal both methods worked.
            Assert.Equal( expected, converter.PersonNameToString( personName ) );
        }

    }
}
