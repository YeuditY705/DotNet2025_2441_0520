using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Sale
{
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int? QuantityForSale { get; set; }
    public double? PriceInSale { get; set; }
    public bool? IsForEveryOne { get; set; }
    public DateTime? StartDateForSale { get; set; }
    public DateTime? EndDateForSale { get; set; }
    public override string ToString() => this.ToStringProperty();

}
