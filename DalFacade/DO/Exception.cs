

namespace DO;

[Serializable]
public class DalIdNotExists: Exception
{
    public DalIdNotExists(String message):base(message)
    {
    }
}

public class DalIdAlreadyExists : Exception
{
    public DalIdAlreadyExists(String message) : base(message)
    {
    }
}

public class DalWrongChoiceExists : Exception
{
    public DalWrongChoiceExists(String message) : base(message)
    {
    }
}


