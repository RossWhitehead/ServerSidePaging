using ServerSidePaging.Model;
using System.Collections.Generic;

namespace ServerSidePaging.ViewModels
{
    public class ProductIndexVM
    {
        public List<Product> Products { get; set; }
        public int Page { get; set; }
        public int TotalCount { get; set; }
    }
}