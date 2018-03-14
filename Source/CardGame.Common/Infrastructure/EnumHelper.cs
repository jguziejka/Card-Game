using System;
using System.Collections.Generic;

namespace CardGame.Common.Infrastructure
{
    public static class EnumHelper
    {
        public static IEnumerable<T> EnumerateType<T>()
        {
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                yield return (T)item;
            }
        }
    }
}
