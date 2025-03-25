using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlImplemementation;

namespace BlApi;

public static class Factory
{
    public static IBL Get() => new Bl();
}
