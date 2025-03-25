using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class SaleInProduct
{
    public int SaleId { get; set; }
    public int? QuantityForSale { get; set; }
    public bool IsForEveryone { get; set; }
    public double PriceInSale { get; set; }
    public override string ToString() => this.ToStringProperty();
   
}
