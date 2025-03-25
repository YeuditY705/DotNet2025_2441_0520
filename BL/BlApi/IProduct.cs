using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi;

public interface IProduct
{
    int Create(Product item);
    Product? Read(int id);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<Product, bool>? filter = null);
    void Update(Product item);
    void Delete(int id);
    List<SaleInProduct> SalesInProduct(int productId, bool IsPreferredCustomer);
}
