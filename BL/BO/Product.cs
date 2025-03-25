using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace BO;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public Categories? Category { get; set; }
    public double? ProductPrice { get; set; }
    public int? ProductQuantity { get; set; }
    public List<SaleInProduct>? SalesInProduct { get; set; }
    public override string ToString() => this.ToStringProperty();
}
