
namespace DalApi;

public interface IDal
{
    IProduct Product { get; }
    ISale Sale { get; }
    ICustomer Customer { get; } 
}
