using System;
using System.Collections.Generic;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Define Input & Output objects
            FileReader InputFile = new FileReader();
            FileWriter OutputFile = new FileWriter("sorted-names-list.txt");
            ScreenPrinter screen = new ScreenPrinter();

            // Define PersonName Objects and List.
            NameSorter nameSorter = new NameSorter();
            PersonNameConverter personNameConverter = new PersonNameConverter();
            List<PersonName> personNameList = new List<PersonName>();

            // only execute the program if an input file was specified.
            if ( args.Length > 0 )
            {
                // load the list of raw unsorted names to a string array.
                string[] rawNames = InputFile.LoadStringArray( args[0] );

                // convert the string array to a list of PersonNames
                personNameList = personNameConverter.StringArrayToPersonNameList( rawNames );
    
                // Perform the sort operation.
                personNameList = nameSorter.SortByLastNameThenFirstName( personNameList );
                
                // convert the PersonName list back to a raw string array
                rawNames = personNameConverter.PersonNameListToStringArray( personNameList );

                // print the list of names to the screen
                screen.PrintArray( rawNames );

                // the sorted name list can now be saved to file
                OutputFile.PrintArray( rawNames );

            } else {
                screen.Print( "Please specify a file to sort." );
            }

        }
    }
}
