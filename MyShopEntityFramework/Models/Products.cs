using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopEntityFramework.Models
{
    public class Product
    {
        int productId;
        string productName;
        int categoryId;
        Category category;
        int supplierId;
        Supplier supplier;
        int price;


        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public Category Category { get => category; set => category = value; }
        public int CategoryID { get => categoryId; set => categoryId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public int Price { get => price; set => price = value; }
        
    }
}
