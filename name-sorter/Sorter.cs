using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    public class Sorter
    {

       private List<SortableName> namesToSort = new List<SortableName>();

        // This adds a name(string) as SortableName to the list of names to sort.
        public void AddName( string name )
        {
            this.namesToSort.Add( new SortableName( name ) );
        }

        // this adds a string array of names as SortbleNames' to the list of names to sort.
        public void AddNameList( string[] nameList )
        {
            for ( int i=0; i<nameList.Length; i++ )
            {
                this.AddName( nameList[i] );
            }
        }

        // This returns the list of SortableNames as a string array.
        public string[] GetNameList()
        {

            // Initialize the string array with the same size of the namesToSort list.
            string[] nameList = new string[this.namesToSort.Count];

            // iterate through each SortableName and grab the original string( name without modifications ).
            for( int i=0; i<this.namesToSort.Count; i++ )
            {
                nameList[i] = this.namesToSort[i].originalString;
            }

            // return the string array of names.
            return nameList;
        }

        public void SortNames(){
            this.namesToSort = this.namesToSort.OrderBy(o=>o.sortString).ToList();
        }


        // Prints the list of SortableNames to the console.
        public void PrintNames()
        {
            for ( int i=0; i<this.namesToSort.Count; i++ )
            {
                this.namesToSort[i].PrintName();
            }
        }

    }
}