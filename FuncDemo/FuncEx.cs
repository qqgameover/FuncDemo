using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemo
{
    public static class FuncEx
    {
        public static TResult Map<TSource, TResult>(this TSource @this,
            Func<TSource, TResult> fn) => fn(@this);

        public static T Tee<T>(this T @this,
            Action<T> act)
        {
            act(@this);
            return @this;
        }
    }
}
