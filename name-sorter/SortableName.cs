using System;

namespace name_sorter
{
    public class SortableName
    {

        // This stores the name in its original format - given names + last name
        public string originalString{ get; private set; }

        // this stores the name in a format suitable for the sorting - last name + given names
        public string sortString{ get; private set; }

        // When initializing a sortable name. This will store the name untouched, then create and store a sortString.
        public SortableName( string name )
        {
            if ( name.Length > 0 )
            {
                this.originalString = name.TrimEnd();
                this.CreateSortString();
            }
            else
            {
                // throw error, please do not use empty names.
            }
        }

        // Since we want to sort the names by last name then by given names, this method will rearange the string
        // so that the last name comes before the given names.
        private void CreateSortString()
        {
            int lastDelim = this.originalString.LastIndexOf( ' ' );
            this.sortString = this.originalString.Substring( lastDelim + 1 ) + ' ' + this.originalString.Substring( 0, lastDelim );
        }

        // Prints the original name to the console.
        public void PrintName() => Console.WriteLine(this.originalString);

    }
}