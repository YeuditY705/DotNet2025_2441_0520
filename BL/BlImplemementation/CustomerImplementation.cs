using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BO.Tools;
//using DalApi;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        try
        {
            return _dal.Customer.Create( item.ConvertToDOCustomer());
        }
        catch (DO.DalIdAlreadyExists e)
        {
            throw new BO.BLIdAlreadyExists("the id already exists",e);
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
            _dal.Customer.Delete(id);
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

    public bool IsExistsCustomer(int id)
    {
        try
        {
            DO.Customer c = _dal.Customer.ReadAll().FirstOrDefault(c => c.customerId == id);
            if (c == null)
                return false;
            return true;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            return _dal.Customer.Read(id).ConvertToBOCustomer();
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

    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(doCustomer => filter(doCustomer.ConvertToBOCustomer())).ConvertToBOCustomer();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            return _dal.Customer.ReadAll(doCustomer => filter(doCustomer.ConvertToBOCustomer())).Select(c => c.ConvertToBOCustomer()).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Update(BO.Customer item)
    {
        try
        {
            _dal.Customer.Update(item.ConvertToDOCustomer());
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

