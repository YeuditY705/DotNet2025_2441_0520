using DalApi;
using DalTest;
using DO;
using System.ComponentModel;
using System.Reflection;
using Tools;
namespace Dal;

internal class Program
{
    enum Object { Customer, Product, Sale }
    private static IDal s_dal = Factory.Get;
    private static void Main(string[] args)
    {
        
        try
        {
            int choise = PrintMainMenu(); //שליחה לפונקציה המדפיסה את התפריט הראשי לבחירת סוג היישות, וקבלת הבחירה 

            while (choise != 0)
            {
                switch (choise)
                {
                    case 1:
                        //customer
                        ICrud<Customer> customerReference = s_dal.Customer; //יצירת מצביע מסוג icrud של הישות 
                        SubMenu(Object.Customer, customerReference); // שליחה לפונקציה לבחירת הפונקציות מתוך היישות הנבחרת
                        break;
                    case 2:
                        //product
                        ICrud<Product> productReference = s_dal.Product;
                        SubMenu(Object.Product, productReference);
                        break;
                    case 3:
                        //sale
                        ICrud<Sale> saleReference = s_dal.Sale;
                        SubMenu(Object.Sale, saleReference);
                        break;
                    case 4:
                        LogManager.cleanLog();
                        break;
                    default:
                        Console.WriteLine("error choise, please select again");
                        break;

                }
                choise = PrintMainMenu();
            }

        }
        catch (Exception e)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
            Console.WriteLine(e);
        }
    }

    private static int PrintMainMenu()
    {
        Console.WriteLine("please select:\n customer press 1\n product press 2\n sale press 3\n clear log press 4\n exit press 0");
        int choise;
        string s = Console.ReadLine();
        if (int.TryParse(s, out choise))
            choise = int.Parse(s);
        else choise = -1;
        return choise;
    }
    private static void SubMenu<T>(Object ob, ICrud<T> icrud)
    {
        int choise = PrintSubMenu(ob); // שליחה לפונקציה לבחירת הפונקציה הנבחרת לישות
        while (choise != 0)
        {
            switch (choise)
            {
                case 1:
                    //create
                    CreateNewObject(ob); //שליחה לפונקציה שיוצרת אובייקט חדש
                    break;
                case 2:
                    //delete
                    DeleteObject(ob, icrud); //שליחה לפונקציה גנרית שמוחקת אובייקט ומקבלת מצביע מסוג icrud 
                    break;
                case 3:
                    //update
                    UpdateObject(ob); //שליחה לפונקציה שמעדכנת את האובייקט
                    break;
                case 4:
                    //read
                    ReadObject(ob, icrud); //שליחה לפונקציה גנרית שמדפיסה אובייקט
                    break;
                case 5:
                    //readAll
                    ReadAllObject(icrud); //שליחה לפונקציה גנרית שמדפיסה את כל האוביקטים מהסוג הזה
                    break;
                default:
                    Console.WriteLine("error choise, please select again");
                    break;
            }
            choise = PrintSubMenu(ob);
        }

    }
    private static int PrintSubMenu(Object ob)
    {
        Console.WriteLine($"please select:\n add {ob} press 1\n delete {ob} press 2\n update {ob} press 3\n read {ob} press 4\n read all {ob}s press 5\n exit press 0");
        int choise;
        string s = Console.ReadLine();
        if (int.TryParse(s, out choise))
            choise = int.Parse(s);
        else choise = -1;
        return choise;
    }
    private static void CreateNewObject(Object ob)
    {
        try
        {
            switch (ob)
            {
                case Object.Customer:
                    CreateNewCustomer();
                    break;
                case Object.Product:
                    CreateNewProduct();
                    break;
                case Object.Sale:
                    CreateNewSale();
                    break;
                default: throw new DalWrongChoiceExists("error choise in create");
            }
        }
        catch (Exception e)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
            Console.WriteLine(e);
        }
    }
    private static void DeleteObject<T>(Object ob, ICrud<T> Icrud)
    {
        Console.WriteLine($"insert id of {ob} to delete");
        int idToDelete;
        int.TryParse(Console.ReadLine(), out idToDelete);
        Icrud.Delete(idToDelete);
    }
    private static void UpdateObject(Object ob)
    {
        try
        {
            switch (ob)
            {
                case Object.Customer:
                    UpdateCustomer();
                    break;
                case Object.Product:
                    UpdateProduct();
                    break;
                case Object.Sale:
                    UpdateSale();
                    break;
                default: throw new DalWrongChoiceExists("error choise in update");
            }
        }
        catch (Exception e)
        {
            LogManager.writingToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
            Console.WriteLine(e);
        }

    }
    private static void ReadObject<T>(Object ob, ICrud<T> Icrud)
    {
        Console.WriteLine($"insert id of {ob} to read");
        int idToRead;
        int.TryParse(Console.ReadLine(), out idToRead);
        Console.WriteLine(Icrud.Read(idToRead));
    }
    private static void ReadAllObject<T>(ICrud<T> Icrud)
    {
        List<T> myList = Icrud.ReadAll();
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
    private static Customer getDataForCustomer()
    {
        int customerId;
        string customerName, customerAddress, customrPhone;
        Console.WriteLine("insert customerId, customerName, customerAddress, customrPhone");
        int.TryParse(Console.ReadLine(), out customerId);
        customerName = Console.ReadLine();
        customerAddress = Console.ReadLine();
        customrPhone = Console.ReadLine();
        return new Customer(customerId, customerName, customerAddress, customrPhone);
    }
    private static void CreateNewCustomer()
    {
        s_dal.Customer.Create(getDataForCustomer());
    }
    private static void UpdateCustomer()
    {

        s_dal.Customer.Update(getDataForCustomer());
    }
    private static Product getDataForProduct(int id = 0)
    {
        Console.WriteLine("insert productName, productPrice, productQuantity");
        string productName = Console.ReadLine();
        double productPrice;
        double.TryParse(Console.ReadLine(), out productPrice);
        int productQuantity;
        int.TryParse(Console.ReadLine(), out productQuantity);
        Categories category = printCategoriesMenu();
        return new Product(id, productName, category, productPrice, productQuantity);
    }
    private static void CreateNewProduct()
    {
        s_dal.Product.Create(getDataForProduct());
    }
    private static void UpdateProduct()
    {
        int id;
        Console.WriteLine("insert id to update");
        int.TryParse(Console.ReadLine(), out id);
        s_dal.Product.Update(getDataForProduct(id));
    }
    private static Sale getDataForSale(int id = 0)
    {
        Console.WriteLine("insert productId, quantityForSale, priceInSale, isForEveryOne, startDateForSale, endDateForSale ");
        int productId, quantityForSale, priceInSale;
        bool isForEveryOne;
        DateTime startDateForSale, endDateForSale;
        int.TryParse(Console.ReadLine(), out productId);
        int.TryParse(Console.ReadLine(), out quantityForSale);
        int.TryParse(Console.ReadLine(), out priceInSale);
        bool.TryParse(Console.ReadLine(), out isForEveryOne);
        DateTime.TryParse(Console.ReadLine(), out startDateForSale);
        DateTime.TryParse(Console.ReadLine(), out endDateForSale);
        return new Sale(id, productId, quantityForSale, priceInSale, isForEveryOne, startDateForSale, endDateForSale);
    }
    private static void CreateNewSale()
    {
        s_dal.Sale.Create(getDataForSale());
    }
    private static void UpdateSale()
    {
        int id;
        Console.WriteLine("insert id to update");
        int.TryParse(Console.ReadLine(), out id);
        s_dal.Sale.Update(getDataForSale(id));

    }
    private static Categories printCategoriesMenu()
    {
        Console.WriteLine($"select category: 0 = {Categories.JEWELES}, 1 = {Categories.SOCKS}, 2 = {Categories.HANDKERCHIEF}, 3 = {Categories.FASHION_PRODUCT}, 4 = {Categories.HAIR_AACCESSORY}");
        int category;
        int.TryParse(Console.ReadLine(), out category);
        return (Categories)category;
    }

}
