
namespace DalTest;
using DO;
using DalApi;
public static class Initialization
{
    private static IDal? s_dal;
    private static void createProducts()
    {
        s_dal.Product.Create(new Product(0, "chain with name", Categories.JEWELES, 150, 20));
        s_dal.Product.Create(new Product(0, "suri handkercheif", Categories.HANDKERCHIEF, 350, 5));
        s_dal.Product.Create(new Product(0, "baby socks", Categories.SOCKS, 20, 15));
        s_dal.Product.Create(new Product(0, "umbrela", Categories.FASHION_PRODUCT, 40, 30));
        s_dal.Product.Create(new Product(0, "girl rainboy", Categories.HAIR_AACCESSORY, 15, 23));
    }

    private static void createCustomers()
    {
        s_dal.Customer.Create(new Customer(789, "Yeuda Coen", "netivot hamishpat 5", "0545555555"));
        s_dal.Customer.Create(new Customer(663, "Shimon Segal", "Jerusalem 15", "054566666"));
        s_dal.Customer.Create(new Customer(747, "Yosef Levi", "Mrome Sade 7", "058566666"));
        s_dal.Customer.Create(new Customer(886, "Avraam Shechter", "Mesilat Yosef 21", "053566666"));
        s_dal.Customer.Create(new Customer(320, "Yona Lang", "Netivot Shalom 7", "052566666"));
    }
    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(0, 100, 1, 135, true, DateTime.Now, new DateTime(2024, 12, 5)));
        s_dal.Sale.Create(new Sale(0, 101, 1, 315, false, new DateTime(2024, 1, 1), new DateTime(2025, 12, 5)));
        s_dal.Sale.Create(new Sale(0, 102, 3, 18, true, DateTime.Now, new DateTime(2024, 12, 5)));
        s_dal.Sale.Create(new Sale(0, 103, 2, 36, false, DateTime.Now, new DateTime(2024, 12, 5)));
        s_dal.Sale.Create(new Sale(0, 104, 4, 13, true, DateTime.Now, new DateTime(2024, 12, 5)));
    }

    public static void Initialize()
    {
        s_dal = Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }
}
