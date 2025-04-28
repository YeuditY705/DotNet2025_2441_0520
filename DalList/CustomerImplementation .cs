
namespace Dal;
using DO;
using DalApi;
using System;
using Tools;
using System.Reflection;
internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to create a customer");
            if (DataSource.Customers.Any(c => c.customerId == item.customerId))
            {
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to exited the function to create a customer");
                LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
                throw new DalIdAlreadyExists("customer id already exists");
            }
            DataSource.Customers.Add(item);
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create a customer");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return item.customerId;
        }
        catch (Exception ex) {
            throw ex;
        }
    }

    public void Delete(int id)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to delete a customer");
        DataSource.Customers.Remove(Read(id));
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete a customer");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
    }

    public Customer? Read(int id)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to read a customer");
        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a customer");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return DataSource.Customers.Single(c => c.customerId == id);
        }
        catch
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to exited the function to read a customer");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            throw new DalIdNotExists("customer id not exists");
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enters the function to read with filter: {filter} a customer");
        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read with filter: {filter} a customer");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return DataSource.Customers.First(filter);
        }
        catch
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to exited the function to read with filter: {filter} a customer");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            throw new DalIdNotExists("customer id not exists");
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enters the function to read all with filter: {filter} customers");
        if (filter != null)
        {
            var filterList = from c in DataSource.Customers
                             where filter(c)
                             select c;
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read all with filter: {filter} customers");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return filterList.ToList();
        }
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all customers");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
        return new List<Customer>(DataSource.Customers);
    }

    public void Update(Customer item)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to update customers");
        Delete(item.customerId);
        DataSource.Customers.Add(item);
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update customer");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
    }
}
