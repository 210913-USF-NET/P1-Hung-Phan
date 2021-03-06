using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using StoreDL;

namespace StoreBL
{
    public class ProductBL : IProduct
    {
        private IRepo _repo;

        public ProductBL(IRepo repo)
        {
            _repo = repo;
        }

        public List<CProduct> ListProducts()
        {
            return _repo.ListProducts();
        }

        public CProduct AddProduct(CProduct products)
        {
            return _repo.AddProduct(products);
        }

        public CProduct showProduct(int id)
        {
            return _repo.showProduct(id);
        }
        public Models.CProduct changeStock(CProduct stockCount)
        {
            return _repo.changeStock(stockCount);
        }

        public List<LineItems> LinesOfItems()
        {
            return _repo.LinesOfItems();
        }

        public void createLineItem(LineItems item)
        {
            _repo.createLineItem(item);
        }

        public CProduct GetProductById(int id)
        {
            return _repo.GetProductById(id);
        }
    }
}