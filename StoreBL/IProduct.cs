using Models;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IProduct
    {
        List<CProduct> ListProducts();

        Models.CProduct changeStock(CProduct stockCount);
    }
}
