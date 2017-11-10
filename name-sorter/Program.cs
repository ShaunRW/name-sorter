using System;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // initialize the sorter and file classs.
            Sorter nameSorter = new Sorter();
            File file = new File();

            // only execute the program if an input file was specified.
            if ( args.Length > 0 ){

                // loads all the names into a string array, then added it to the name sorter and sorts them.
                // the load function makes sure the specfied input file exists.
                nameSorter.AddNameList( file.Load( args[0] ) );
                
                // Sort the list of names and print them to the screen.
                nameSorter.SortNames();
                nameSorter.PrintNames();

                // the sorted name list can be saved to file and printed to the screen.
                file.Save( "sorted-names-list.txt", nameSorter.GetNameList() );

            } else {
                Console.WriteLine( "Please specify a file to sort." );
            }

        }
    }
}
