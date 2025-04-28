
using BlApi;
using DalTest;

namespace BO;

internal class Program
{
    static readonly IBL s_bl = Factory.Get();
    public static void Main(string[] args)
    {
        try
        {
            //s_bl.Product.ReadAll().ToStringProperty();
           // s_bl.Sale.ReadAll().SelectMany(p => p.ToStringProperty().Split("\n")).ToList();
           // Product product=s_bl.Product.Read(104);
            //s_bl.Product.Update(product);
            //s_bl.Customer.ReadAll().Select(c => c.ToStringProperty());
            Console.WriteLine("to Initialize press 1, not Initialize press other");
            int init;
            int.TryParse(Console.ReadLine(), out init);
            if (init == 1)
                Initialization.Initialize();

            //Initialization.Initialize();
            int id;
            Console.WriteLine("insert id");
            string firstId = Console.ReadLine();
            if (int.TryParse(firstId, out id))
                id = int.Parse(firstId);
            else id = 0;
            int isContinue = 1;
            int productId, count;
            Order order = new Order(s_bl.Customer.IsExistsCustomer(id));
            List<SaleInProduct> sales = new List<SaleInProduct>();
            while (isContinue == 1)
            {
                Console.WriteLine("insert product id and count");
                int.TryParse(Console.ReadLine(), out productId);
                int.TryParse(Console.ReadLine(), out count);
                sales = s_bl.Order.AddProductToOrder(order, productId, count);
                
                Console.WriteLine("final price for order = " + order.FinalPrice);
                Console.WriteLine("To another order press 1, to exit press 0");
                int.TryParse(Console.ReadLine(), out isContinue);
            }
 //           order.ToStringProperty();
            foreach (SaleInProduct sale in sales)
            {
                Console.WriteLine(sale.ToStringProperty());
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
 }
