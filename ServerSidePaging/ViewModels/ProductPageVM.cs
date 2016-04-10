using ServerSidePaging.Model;
using System.Collections.Generic;

namespace ServerSidePaging.ViewModels
{
    public class ProductPageVM
    {
        public List<Product> Products { get; set; }
        public int Page { get; set; }
    }
}