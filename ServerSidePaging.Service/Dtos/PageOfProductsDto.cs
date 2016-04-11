using ServerSidePaging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSidePaging.Service.Dtos
{
    public class PageOfProductsDto
    {
        public IEnumerable<Product> Products { get; set; }
        public int TotalCount { get; set; }

    }
}
