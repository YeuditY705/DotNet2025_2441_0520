using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;


namespace BlImplemementation;

internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {

        try
        {
            return _dal.Sale.Create(item.ConvertToDOSale());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
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

    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).ConvertToBOSale();
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

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(doSale => filter(doSale.ConvertToBOSale())).ConvertToBOSale();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter != null)
                return _dal.Sale.ReadAll(doSale => filter(doSale.ConvertToBOSale())).Select(c => c.ConvertToBOSale()).ToList();
            return _dal.Sale.ReadAll().Select(c => c.ConvertToBOSale()).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.ConvertToDOSale());
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
}
