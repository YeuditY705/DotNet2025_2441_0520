

namespace DO;

public record Product
    (
    int productId,
    string? productName = null,
    Categories? category = null,
    double? productPrice = null,
    int? productQuantity = null
    )
{
    public Product():this(0)
    {
        
    }
}
