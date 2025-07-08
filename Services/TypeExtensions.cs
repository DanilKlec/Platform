using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Services;

public static class TypeExtensions
{
    public static bool IsAssignableFromGeneric(this Type genericType, Type type)
    {
        while (type != null && type != typeof(object))
        {
            var cur = type.IsGenericType ? type.GetGenericTypeDefinition() : type;
            if (genericType == cur)
                return true;
            type = type.BaseType!;
        }
        return false;
    }
}
