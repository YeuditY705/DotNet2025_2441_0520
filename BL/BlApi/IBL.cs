using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IBL
{
    IProduct Product { get; }
    ISale Sale { get; }
    ICustomer Customer { get; }
    IOrder Order { get; }

}
