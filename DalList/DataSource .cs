

namespace Dal;
using DO;

internal static class DataSource
{
    internal static List<Product?>  Products = new List<Product?>();
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config
    {
        internal const int ProductMinCode = 100;
        internal const int SaleMinCode = 100;

        private static int ProductRunningNum = ProductMinCode;
        private static int SaleRunningNum = SaleMinCode;

        public static int ProductCod
        {
            get
            {
                return ProductRunningNum++;
            }
        }

        public static int SailCod
        {
            get
            {
                return SaleRunningNum++;
            }
        }

    }

}

