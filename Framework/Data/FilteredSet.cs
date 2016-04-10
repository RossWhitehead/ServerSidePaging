using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class FilteredSet<TEntity> where TEntity : class
    {
        public FilteredSet(IEnumerable<TEntity> set, int totalCount)
        {
            Set = set;
            TotalCount = totalCount;
        }

        public IEnumerable<TEntity> Set { get; set; }
        public int TotalCount { get; set; }
    }
}
