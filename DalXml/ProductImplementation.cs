//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Runtime.Serialization;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;
//using DalApi;
//using DO;

//namespace Dal;
//internal class ProductImplemention : IProduct
//{
//    static string filePath = @"..\xml\products.xml";
//    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
//    static List<Product> Products = new List<Product>();


//    public int Create(Product item)
//    {
//        try
//        {
//            item = item with { productId = Config.nextProductId };
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }
//            }

//            Products.Add(item);
//            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
//            {
//                serializer.Serialize(fs, Products);
//            }
//            return item.productId;
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }

//    public void Delete(int id)
//    {
//        try
//        {
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }

//                Product productToDelete = Products.FirstOrDefault(p => p.productId == id);
//                if (productToDelete != null)
//                {
//                    Products.Remove(productToDelete);
//                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
//                    {
//                        serializer.Serialize(fs, Products);
//                    }
//                }
//                else throw new DO.DalIdNotExists("id not exist");
//            }
//        }

//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }

//    public Product? Read(int id)
//    {
//        try
//        {
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }

//                Product findProduct = Products.FirstOrDefault(p => p.productId == id);

//                if (findProduct != null)
//                    return findProduct;
//                else throw new DO.DalIdNotExists("id not exist");
//            }

//            return null;
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }

//    public Product? Read(Func<Product, bool> filter)
//    {
//        try
//        {
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }

//                Product findProduct = Products.FirstOrDefault(filter);

//                if (findProduct != null)
//                    return findProduct;
//                else throw new DO.DalIdNotExists("id not exist");
//            }
//            return null;
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }

//    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
//    {
//        try
//        {
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }
//                if (filter == null)
//                    return Products.ToList();
//                var filterList = from p in Products
//                                 where filter(p)
//                                 select p;
//                return filterList.ToList();
//            }
//            return null;

//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }

//    }

//    public void Update(Product item)
//    {

//        try
//        {
//            Delete(item.productId);
//            if (File.Exists(filePath))
//            {
//                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//                {
//                    Products = (List<Product>)serializer.Deserialize(fs);
//                }

//                Products.Add(item);
//            }
//            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
//            {
//                serializer.Serialize(fs, Products);
//            }
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }


//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    static string filePath = @"..\xml\products.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    static List<Product> Products = new List<Product>();

    public int Create(Product item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to create a product");

            item = item with { productId = Config.nextProductId };
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }
            }

            Products.Add(item);
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Products);
            }

            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create a product");
            LogManager.space = LogManager.space.Substring(0, LogManager.space.Length - 1);
            return item.productId;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to create product: {ex.Message}");
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to delete a product");

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Product productToDelete = Products.FirstOrDefault(p => p.productId == id);
                if (productToDelete != null)
                {
                    Products.Remove(productToDelete);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        serializer.Serialize(fs, Products);
                    }

                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete a product");
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to delete product: id does not exist");
                    throw new DO.DalIdNotExists("id not exist");
                }
            }
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to delete product: {ex.Message}");
            throw;
        }
    }

    public Product? Read(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read a product");

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Product findProduct = Products.FirstOrDefault(p => p.productId == id);
                if (findProduct != null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a product");
                    return findProduct;
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to read product: id does not exist");
                    throw new DO.DalIdNotExists("id not exist");
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read product: {ex.Message}");
            throw;
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read a product with filter");

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Product findProduct = Products.FirstOrDefault(filter);
                if (findProduct != null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a product with filter");
                    return findProduct;
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to read product with filter: id does not exist");
                    throw new DO.DalIdNotExists("id not exist");
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read product with filter: {ex.Message}");
            throw;
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to read all products");

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                if (filter == null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all products");
                    return Products.ToList();
                }

                var filterList = from p in Products
                                 where filter(p)
                                 select p;

                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all products with filter");
                return filterList.ToList();
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read all products: {ex.Message}");
            throw;
        }
    }

    public void Update(Product item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Entering the function to update a product");

            Delete(item.productId);
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Products.Add(item);
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(fs, Products);
                }

                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update a product");
            }
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to update product: {ex.Message}");
            throw;
        }
    }
}
