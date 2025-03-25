using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Order
{
    public bool IsPreferredCustomer { get; set; }
    public List<ProductInOrder> ProductInOrder { get; set; }
    public double FinalPrice { get; set; } 
    public override string ToString() => this.ToStringProperty();

    public Order(bool isPreferredCustomer)
    {
        IsPreferredCustomer = isPreferredCustomer;
    }
}
