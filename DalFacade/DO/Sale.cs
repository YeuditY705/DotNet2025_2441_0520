using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale
        (
        int saleId,
        int productId,
        int? quantityForSale = null,
        double? priceInSale = null,
        bool? isForEveryOne = null,
        DateTime? startDateForSale = null,
        DateTime? endDateForSale = null
        )
    {
        public Sale():this(0,0)
        {
            
        }
    }
}
