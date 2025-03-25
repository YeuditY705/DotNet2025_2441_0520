
namespace Dal;
using DO;
using DalApi;
using System;
using Tools;
using System.Reflection;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enter the function to create product");
            Product product = item with { productId = DataSource.Config.ProductCod };
            DataSource.Products.Add(product);
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return product.productId;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public void Delete(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enter the function to delete product");
            DataSource.Products.Remove(Read(id));
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Product? Read(int id)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enter the function to read a product");

        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return DataSource.Products.Single(p => p.productId == id);
        }
        catch
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to exited the function to read a product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length);
            throw new DalIdNotExists("product id not exists");
        }

    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enter the function to read with filter: {filter} aproduct");

        try
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read with filter: {filter} a product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length);

            return DataSource.Products.First(filter);
        }
        catch
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to exited the function to read with filter: {filter} a product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length);

            throw new DalIdNotExists("product id not exists");
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Enter the function to read all with filter: {filter} products");


        if (filter != null)
        {
            var filterList = from p in DataSource.Products
                             where filter(p)
                             select p;
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully exited the function to read all with filter: {filter} products");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length);
            return filterList.ToList();
        }
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all products");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length);

        return new List<Product>(DataSource.Products);
    }

    public void Update(Product item)
    {
        LogManager.space += "\t";
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enter the function to update product");
        Delete(item.productId);
        DataSource.Products.Add(item);
        LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update product");
        LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);

    }
}
