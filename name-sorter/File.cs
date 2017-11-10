using System;

namespace name_sorter
{
    public class File
    {

        // Checks whether a files exists. returns true or false.
        public bool Exists( string fileName )
        {
            return System.IO.File.Exists( fileName );
        }

        // loads the contents of a file into a string array.
        public string[] Load( string fileName )
        {

            string[] LoadedNameList = new string[] {};

            try
            {
                LoadedNameList = System.IO.File.ReadAllLines( fileName );
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine($"File '{fileName}' does not exist. Try entering a different file name.");
            }

            return LoadedNameList;
        }

        // Saves the contents of a string array into a file.
        public void Save( string fileName, string[] nameList )
        {
            System.IO.File.WriteAllLines( fileName, nameList );
        }


    }
}
