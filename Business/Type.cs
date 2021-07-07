using System;
using System.Collections.Generic;
using System.Text;

namespace Holism.Configuration.Business
{
    public enum Type
    {
        Unknown = 0,
        Text = 1,
        Numerical = 2,
        PositiveNumber = 3,
        Integer = 4,
        Decimal = 5,
        Options = 6,
        Color = 7,
        Boolean = 8,
        NullableBoolean = 9
    }
}
