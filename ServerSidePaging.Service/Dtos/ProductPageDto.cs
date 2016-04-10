using ServerSidePaging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSidePaging.Service.Dtos
{
    public class ProductPageDto
    {
        List<Product> Products { get; set; }
        public int Page { get; set; }
    }
}
