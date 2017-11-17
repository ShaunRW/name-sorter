using System;

namespace name_sorter
{
    public class FileWriter: IStringPrinter
    {

        public string filename;

        public FileWriter( string file )
        {
            this.filename = file;
        }

        // write a single line of text the file.
        public void Print( string str )
        {
            System.IO.File.WriteAllText( this.filename, str );
        }

        // writes multiple lines of text from the string array to the file.
        public void PrintArray( string[] strArray )
        {
            System.IO.File.WriteAllLines( this.filename, strArray );
        }


    }
}
