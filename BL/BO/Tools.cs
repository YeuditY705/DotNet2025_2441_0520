using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public static class Tools
{
    public static string ToStringProperty<T>(this T t)
    {
        string str = "";
        Type Ttype = t.GetType();
        PropertyInfo[] info = Ttype.GetProperties();
        foreach (PropertyInfo item in info)
        {
            if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
            {
                IEnumerable collection = item.GetValue(t) as IEnumerable;
                foreach (var x in collection)
                {
                    str += x.ToStringProperty();
                }
            }
            else
                str += string.Format("{0,-15}:{1,-15}\n", item.Name, item.GetValue(t, null));

        }
        return str;
    }


    public static BO.Customer ConvertToBOCustomer(this DO.Customer customer)=> new() { CustomerId = customer.customerId, CustomerAddress = customer.customerAddress, CustomerName = customer.customerName, CustomerPhone = customer.customerPhone };
       
    public static DO.Customer ConvertToDOCustomer(this BO.Customer customer)=> new() { customerId = customer.CustomerId, customerName = customer.CustomerName, customerAddress = customer.CustomerAddress, customerPhone = customer.CustomerPhone };
       
    public static BO.Product ConvertToBOProduct(this DO.Product product)=> new() { Category = (Categories?)product.category, ProductId = product.productId, ProductName = product.productName, ProductPrice = product.productPrice, ProductQuantity = product.productQuantity };

    public static DO.Product ConvertToDOProduct(this BO.Product product)=> new() { productId = product.ProductId, category = (DO.Categories?)product.Category, productName = product.ProductName, productPrice = product.ProductPrice, productQuantity = product.ProductQuantity };
       
    public static BO.Sale ConvertToBOSale(this DO.Sale sale)=> new() { SaleId = sale.saleId, ProductId = sale.productId, EndDateForSale = sale.endDateForSale, IsForEveryOne = sale.isForEveryOne, PriceInSale = sale.priceInSale, QuantityForSale = sale.quantityForSale, StartDateForSale = sale.startDateForSale };
      
    public static DO.Sale ConvertToDOSale(this BO.Sale sale)=> new() { productId = sale.ProductId,saleId = sale.SaleId,priceInSale = sale.PriceInSale,endDateForSale = sale.EndDateForSale,isForEveryOne = sale.IsForEveryOne,quantityForSale = sale.QuantityForSale,startDateForSale = sale.StartDateForSale };

    public static BO.SaleInProduct ConvertToBOSaleInProduct(this DO.Sale sale)=> new() {  IsForEveryone = sale.isForEveryOne ?? false,PriceInSale = sale.priceInSale ?? 0,QuantityForSale = sale.quantityForSale,SaleId= sale.saleId };

    public static BO.ProductInOrder ConvertToBOProductInOrder(this DO.Product product)=> new() {BasePrice = product.productPrice,ProductId = product.productId,ProductName = product.productName,Quantity = product.productQuantity };

        
       
}



