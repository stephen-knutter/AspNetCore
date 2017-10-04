using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithVisualStudio.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product p);
    }
}
