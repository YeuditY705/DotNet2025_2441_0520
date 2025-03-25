using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BlImplementation;

namespace BlImplemementation;

internal class Bl : IBL
{
    public IProduct Product => new ProductImplementatiton();

    public ISale Sale => new SaleImplementation();

    public ICustomer Customer => new CustomerImplementation();

    public IOrder Order => new OrderImplementatiton();
}
