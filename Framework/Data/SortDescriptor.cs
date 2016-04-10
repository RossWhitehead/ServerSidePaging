using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class SortDescriptor
    {
        public SortDescriptor(string member, ListSortDirection sortDirection)
        {
            Member = member;
            SortDirection = sortDirection;
        }

        public string Member { get; set; }
        public ListSortDirection SortDirection { get; set; }
    }
}