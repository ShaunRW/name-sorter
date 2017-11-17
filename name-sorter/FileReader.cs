using System;

namespace name_sorter
{
    public class FileReader
    {

        ScreenPrinter screen = new ScreenPrinter();

        // Reads the contents of a file and returns it as a string array.
        public string[] LoadStringArray( string fileName )
        {

            string[] strArray = new string[] {};

            try
            {
                strArray = System.IO.File.ReadAllLines( fileName );
            }
            catch (System.IO.IOException)
            {
                screen.Print( $"File '{fileName}' does not exist. Try entering a different file name." );
            }

            return strArray;
        }


    }
}
