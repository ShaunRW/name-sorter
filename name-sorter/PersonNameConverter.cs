using System;
using System.Collections.Generic;

namespace name_sorter
{
    public class PersonNameConverter
    {

        // Converts a string value to a PersonName object.
        public PersonName StringToPersonName( string rawName )
        {

            // Find the position of the last space character in the string.
            // This will out delimiter to separate the given and last names.
            int lastDelim = rawName.LastIndexOf( ' ' );
            
            // initialize a PersonName Object
            PersonName personName = new PersonName();

            // Split the string and set the PersonName properties.
            personName.lastName = rawName.Substring( lastDelim + 1 );
            personName.givenNames = rawName.Substring( 0, lastDelim );

            // return the new PersonNameObject
            return personName;
        }

        // Converts an array of string values to a list of PersonName objects.
        public List<PersonName> StringArrayToPersonNameList( string[] rawNames )
        {

            // init the list of PersonName objects and a single 'temp' PersonName for holding.
            List<PersonName> personNames = new List<PersonName>();
            PersonName tempPersonName = new PersonName();

            foreach( string rawName in rawNames )
            {
                // convert this string to PersonName and add it to the list.
                tempPersonName = this.StringToPersonName( rawName );
                personNames.Add( tempPersonName );
            }

            // return the list of person names.
            return personNames;

        }

        // This takes a PersonName object, concatenates the first and last names to create a single string value of the name.
        public string PersonNameToString( PersonName personName )
        {
            return personName.givenNames + ' ' + personName.lastName;
        }

        // This takes a list of PersonName objects, concatenates the first and last names of each object, to create a string array of raw names.
        public string[] PersonNameListToStringArray( List<PersonName> personNameList )
        {
            // init the string array to same size as the list.
            string[] rawNames = new string[personNameList.Count];

            // convert each name and store it in the array.
            for( int i=0; i<personNameList.Count; i++ )
            {
                rawNames[i] = this.PersonNameToString( personNameList[i] );
            }

            return rawNames;
        }

    }
}