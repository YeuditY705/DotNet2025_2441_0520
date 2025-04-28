

namespace Dal;
using DO;
using DalApi;
using System;
using System.Reflection;
using Tools;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to create a sale");
            Sale sale = item with { saleId = DataSource.Config.SailCod };
            DataSource.Sales.Add(sale);
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return sale.saleId;
        }
        catch (Exception ex) {
            throw ex;
        }
    }

    public void Delete(int id)
    {
        try {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to delete a sale");
            DataSource.Sales.Remove(Read(id));
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Sale? Read(int id)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to read a sale");
        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return DataSource.Sales.Single(s => s.saleId == id);
        }
        catch
        {

            throw new DalIdNotExists("sale id not exists");
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enters the function to read with fiter: {filter} a sale");
        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read with fiter: {filter} a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return DataSource.Sales.First(filter);
        }
        catch
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to exited the function to read with fiter: {filter} a sale");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            throw new DalIdNotExists("sale id not exists");
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try { 
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enters the function to read all sales with fiter: {filter}");
        if (filter != null)
        {
            var filterList = from s in DataSource.Sales
                             where filter(s)
                             select s;
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read all with fiter: {filter} sales");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return filterList.ToList();
        }
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all sales");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
        return new List<Sale>(DataSource.Sales);}
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Update(Sale item)
    {
        try { 
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to update a sale");
        Delete(item.saleId);
        DataSource.Sales.Add(item);
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update a sale");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
    }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
