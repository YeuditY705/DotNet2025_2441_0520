using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

[Serializable]
public class  BLIdNotExists : Exception
{
    public BLIdNotExists(String message) : base(message)
    {
    }
    public BLIdNotExists(string message, Exception innerException)
                : base(message, innerException) { }

}

public class BLIdAlreadyExists : Exception
{
    public BLIdAlreadyExists(String message) : base(message)
    {
    }
    public BLIdAlreadyExists(string message, Exception innerException)
                : base(message, innerException) { }
}

public class BLWrongChoiceExists : Exception
{
    public BLWrongChoiceExists(String message) : base(message)
    {
    }
    public BLWrongChoiceExists(string message, Exception innerException)
                : base(message, innerException) { }
}

public class BLnotEnoughInStock : Exception
{
    public BLnotEnoughInStock(String message) : base(message)
    {
    }
}

