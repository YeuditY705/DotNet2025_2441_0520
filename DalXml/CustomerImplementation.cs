//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;
//using DalApi;
//using DO;
//using Tools;

//namespace Dal;

//[Serializable]
//internal class CustomerImplementation : ICustomer
//{
//    static string file_path = "../xml/customers.xml";
//    static XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

//    public int Create(Customer item)
//    {
//        try
//        {

//            List<Customer> customers = new List<Customer>();
//            // אם הקובץ קיים, טוען את הלקוחות הקיימים
//            if (File.Exists(file_path))
//            {
//                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    customers = (List<Customer>)serializer.Deserialize(fs);
//                }
//            }
//            Customer findCustomer = customers
//                    .FirstOrDefault(c => c.customerId == item.customerId);
//            if (findCustomer != null)
//                throw new DO.DalIdAlreadyExists("id already exists");
//            // הוספת הלקוח החדש לרשימה
//            customers.Add(item);

//            // שומר את הלקוחות לקובץ XML
//            using (FileStream fs = new FileStream(file_path, FileMode.Open))
//            {
//                serializer.Serialize(fs, customers);
//            }
//            return item.customerId;
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

//            List<Customer> customers = new List<Customer>();
//            if (File.Exists(file_path))
//            {
//                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    customers = (List<Customer>)serializer.Deserialize(fs);
//                }

//                Customer customerToDelete = customers
//                    .FirstOrDefault(c => c.customerId == id);
//                if (customerToDelete != null)
//                {
//                    customers.Remove(customerToDelete);
//                    using (FileStream fs = new FileStream(file_path, FileMode.Create)) // שים לב לשינוי כאן
//                    {
//                        serializer.Serialize(fs, customers);
//                    }
//                }
//                else
//                    throw new DO.DalIdNotExists("id not exists");
//            }
//        }

//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }

//    public Customer? Read(int id)
//    {
//        try
//        {
//            List<Customer> customers = new List<Customer>();
//            if (File.Exists(file_path))
//            {
//                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    customers = (List<Customer>)serializer.Deserialize(fs);
//                }
//                Customer findCustomer = customers
//                    .FirstOrDefault(c => c.customerId == id);
//                if (findCustomer != null)
//                    return findCustomer;
//                else throw new DO.DalIdNotExists("id not exists");

//            }
//            return null;
//        }
//        catch (Exception ex) { throw ex; }
//    }

//    public Customer? Read(Func<Customer, bool> filter)
//    {
//        try
//        {
//            List<Customer> customers = new List<Customer>();
//            if (File.Exists(file_path))
//            {
//                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    customers = (List<Customer>)serializer.Deserialize(fs);
//                }
//                Customer findCustomer = customers
//                    .FirstOrDefault(filter);
//                return findCustomer;

//            }
//            return null;
//        }
//        catch (Exception ex) { throw ex; }
//    }

//    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
//    {
//        try
//        {
//            List<Customer> customers = new List<Customer>();
//            if (File.Exists(file_path))
//            {
//                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
//                {
//                    customers = (List<Customer>)serializer.Deserialize(fs);
//                }
//                if (filter == null)
//                    return customers;
//                var filterList = from c in customers
//                                 where filter(c)
//                                 select c;
//                return filterList.ToList();

//            }
//            return null;
//        }
//        catch (Exception ex) { throw ex; }
//    }

//    public void Update(Customer item)
//    {
//        try
//        {
//            Delete(item.customerId);
//            Create(item);
//        }
//        catch (Exception ex) { throw ex; }
//    }
//}
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

[Serializable]
internal class CustomerImplementation : ICustomer
{
    static string file_path = "../xml/customers.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

    public int Create(Customer item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to create a customer");

            List<Customer> customers = new List<Customer>();
            // אם הקובץ קיים, טוען את הלקוחות הקיימים
            if (File.Exists(file_path))
            {
                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
                {
                    customers = (List<Customer>)serializer.Deserialize(fs);
                }
            }
            Customer findCustomer = customers
                    .FirstOrDefault(c => c.customerId == item.customerId);
            if (findCustomer != null)
            {
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to create customer: id already exists");
                throw new DO.DalIdAlreadyExists("id already exists");
            }
            // הוספת הלקוח החדש לרשימה
            customers.Add(item);

            // שומר את הלקוחות לקובץ XML
            using (FileStream fs = new FileStream(file_path, FileMode.Create))
            {
                serializer.Serialize(fs, customers);
            }
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to create a customer");
            return item.customerId;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to create customer: {ex.Message}");
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to delete a customer");

            List<Customer> customers = new List<Customer>();
            if (File.Exists(file_path))
            {
                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
                {
                    customers = (List<Customer>)serializer.Deserialize(fs);
                }

                Customer customerToDelete = customers
                    .FirstOrDefault(c => c.customerId == id);
                if (customerToDelete != null)
                {
                    customers.Remove(customerToDelete);
                    using (FileStream fs = new FileStream(file_path, FileMode.Create))
                    {
                        serializer.Serialize(fs, customers);
                    }
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to delete a customer");
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to delete customer: id not exists");
                    throw new DO.DalIdNotExists("id not exists");
                }
            }
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to delete customer: {ex.Message}");
            throw;
        }
    }

    public Customer? Read(int id)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to read a customer");

            List<Customer> customers = new List<Customer>();
            if (File.Exists(file_path))
            {
                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
                {
                    customers = (List<Customer>)serializer.Deserialize(fs);
                }
                Customer findCustomer = customers
                    .FirstOrDefault(c => c.customerId == id);
                if (findCustomer != null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a customer");
                    return findCustomer;
                }
                else
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed to read customer: id not exists");
                    throw new DO.DalIdNotExists("id not exists");
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read customer: {ex.Message}");
            throw;
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to read a customer with filter");

            List<Customer> customers = new List<Customer>();
            if (File.Exists(file_path))
            {
                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
                {
                    customers = (List<Customer>)serializer.Deserialize(fs);
                }
                Customer findCustomer = customers
                    .FirstOrDefault(filter);
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read a customer with filter");
                return findCustomer;
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read customer with filter: {ex.Message}");
            throw;
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to read all customers");

            List<Customer> customers = new List<Customer>();
            if (File.Exists(file_path))
            {
                using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite))
                {
                    customers = (List<Customer>)serializer.Deserialize(fs);
                }
                if (filter == null)
                {
                    LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all customers");
                    return customers;
                }
                var filterList = from c in customers
                                 where filter(c)
                                 select c;
                LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to read all customers with filter");
                return filterList.ToList();
            }
            return null;
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to read all customers: {ex.Message}");
            throw;
        }
    }

    public void Update(Customer item)
    {
        try
        {
            LogManager.space += "\t";
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Enters the function to update a customer");

            Delete(item.customerId);
            Create(item);
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully exited the function to update a customer");
        }
        catch (Exception ex)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Failed to update customer: {ex.Message}");
            throw;
        }
    }
}
