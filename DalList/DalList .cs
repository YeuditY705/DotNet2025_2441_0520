

using DalApi;

namespace Dal;

internal sealed class DalList:IDal
{
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public ICustomer Customer => new CustomerImplementation();
    static readonly DalList instance = new DalList();
    public static DalList Instance { get { return instance; } } 
    private DalList() { }

}
