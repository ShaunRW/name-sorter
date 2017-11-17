using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    public class NameSorter
    {
        public List<PersonName> SortByLastNameThenFirstName( List<PersonName> namesToSort )
        {
            return namesToSort.OrderBy(o=>o.lastName).ThenBy(o=>o.givenNames).ToList();
        }

    }
}