using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;




namespace BlImplemementation;

internal class OrderImplementatiton : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity)
    {
        try
        {
            DO.Product product = _dal.Product.Read(productId);
            
            BO.ProductInOrder myProduct = order.ProductInOrder?.FirstOrDefault(p => p.ProductId == productId);
            if (myProduct != null)
            {
                if (myProduct.Quantity + quantity <= product.productQuantity)
                {
                    myProduct.Quantity += quantity;
                }
                else
                    throw new BO.BLnotEnoughInStock("not enough in stock");
   
            }
            else
            {
                if (product.productQuantity - quantity >= 0)
                {
                    myProduct = product.ConvertToBOProductInOrder();
                    myProduct.Quantity = quantity;
                    if (order.ProductInOrder == null)
                        order.ProductInOrder = new List<BO.ProductInOrder>();
                    order.ProductInOrder.Add(myProduct);
             
                }
                else
                {
                    throw new BO.BLnotEnoughInStock("not enough in stock");
                }
            }
            SearchSaleForProduct(myProduct, order.IsPreferredCustomer);
            CalcTotalPriceForProduct(myProduct);
            CalcTotalPrice(order);
            return myProduct.SaleForProduct;

        }
        catch (DO.DalIdNotExists e)
        {
            throw new BO.BLIdNotExists("the id not exists", e);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            order.FinalPrice = order.ProductInOrder.Sum(p => p.FinalPrice);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {
        try
        {
            int count = productInOrder.Quantity ?? 0;
            List<BO.SaleInProduct> salesInProduct = new List<BO.SaleInProduct>();
            foreach (BO.SaleInProduct saleInProduct in productInOrder.SaleForProduct)
            {
                if(count == 0)
                    break;
                if (count >= saleInProduct.QuantityForSale) {
                    int times = count / saleInProduct.QuantityForSale ?? 0;
                    productInOrder.FinalPrice += times * saleInProduct.PriceInSale;
                    count = count % saleInProduct.QuantityForSale ?? 0;
                    salesInProduct.Add(saleInProduct);
                }
                else
                    continue;
            }
            if (count > 0)
                productInOrder.FinalPrice += count * productInOrder.BasePrice ?? 0;
            productInOrder.SaleForProduct = salesInProduct;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder product in order.ProductInOrder)
            {
                DO.Product p = _dal.Product.Read(product.ProductId);
                int count = p.productQuantity?? 0 - product.Quantity ?? 0;
                
                _dal.Product.Update(p with { productQuantity = count});
            }
        }
        catch (DO.DalIdNotExists e)
        {
            throw new BO.BLIdNotExists("the id not exists", e);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool IsPreferredCustomer)
    {
        try
        {
            productInOrder.SaleForProduct = _dal.Sale.ReadAll(s => s.productId == productInOrder.ProductId && (s.isForEveryOne ==true  || IsPreferredCustomer) && DateTime.Now >= s.startDateForSale && DateTime.Now <= s.endDateForSale && s.quantityForSale<= productInOrder.Quantity).Select(s => s.ConvertToBOSaleInProduct()).OrderBy(s=> s.PriceInSale/s.QuantityForSale).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

}
