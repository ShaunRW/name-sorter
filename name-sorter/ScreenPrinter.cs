using System;

namespace name_sorter
{
    public class ScreenPrinter: IStringPrinter
    {

        // Prints a single line of text the the console.
        public void Print( string str )
        {
            Console.WriteLine( str );
        }

        // Prints an array of string to the console.
        public void PrintArray( string[] strArray )
        {
            foreach( string str in strArray )
            {
                this.Print( str );
            }
        }

    }
}