using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;


namespace BlImplemementation;

internal class ProductImplementatiton :BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product item)
    {
        try
        {
            return _dal.Product.Create(item.ConvertToDOProduct());
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
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

    public BO.Product? Read(int id)
    {
        try
        {
            return _dal.Product.Read(id).ConvertToBOProduct();
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

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(doProduct => filter(doProduct.ConvertToBOProduct())).ConvertToBOProduct();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
           if(filter==null)
                return _dal.Product.ReadAll().Select(p => p.ConvertToBOProduct()).ToList();
            return _dal.Product.ReadAll(doProduct => filter(doProduct.ConvertToBOProduct())).Select(p => p.ConvertToBOProduct()).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.SaleInProduct> SalesInProduct(int productId, bool IsPreferredCustomer)
    {
        try
        {
            return _dal.Sale.ReadAll(s => s.productId == productId && (s.isForEveryOne??false || IsPreferredCustomer) && DateTime.Now >= s.startDateForSale && DateTime.Now <= s.endDateForSale).Select(s => s.ConvertToBOSaleInProduct()).ToList();
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

    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.ConvertToDOProduct());
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
}
