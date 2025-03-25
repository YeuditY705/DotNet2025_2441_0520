using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;
internal class ProductImplemention : IProduct
{
    static string filePath = @"..\xml\products.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    static List<Product> Products = new List<Product>();


    public int Create(Product item)
    {
        try
        {
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
            return item.productId;
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
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        serializer.Serialize(fs, Products);
                    }
                }
                else throw new DO.DalIdNotExists("id not exist");
            }
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Product? Read(int id)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Product findProduct = Products.FirstOrDefault(p => p.productId == id);

                if (findProduct != null)
                    return findProduct;
                else throw new DO.DalIdNotExists("id not exist");
            }

            return null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Product findProduct = Products.FirstOrDefault(filter);

                if (findProduct != null)
                    return findProduct;
                else throw new DO.DalIdNotExists("id not exist");
            }
            return null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                var filterList = from p in Products
                                 where filter(p)
                                 select p;
                return filterList.ToList();
            }
            return null;

        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    public void Update(Product item)
    {

        try
        {
            Delete(item.productId);
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }

                Products.Add(item);
            }
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Products);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }


    }
}

