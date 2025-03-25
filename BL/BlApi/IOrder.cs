using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(Order order,int productId,int quantity);
    void CalcTotalPriceForProduct(ProductInOrder product);
    void CalcTotalPrice(Order order);
    void DoOrder(Order order);
    public void SearchSaleForProduct(BO.ProductInOrder ProductInOrder, bool IsPreferredCustomer);
  }
