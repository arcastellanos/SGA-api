using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA_api.Models;

namespace SGA_api.Interface
{
    public interface ISaveProducts
    {
        void PostProduct(Product myProduct);
    }
}