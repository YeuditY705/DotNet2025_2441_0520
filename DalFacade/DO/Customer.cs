

namespace DO;

public record Customer
    (
    int customerId,
    string? customerName = null,
    string? customerAddress = null,
    string? customerPhone = null
    )
{
    public Customer():this(0)
    {
        
    }
}
