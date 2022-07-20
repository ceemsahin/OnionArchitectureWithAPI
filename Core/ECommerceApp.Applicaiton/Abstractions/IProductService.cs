using ECommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Applicaiton.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();

    }
}
