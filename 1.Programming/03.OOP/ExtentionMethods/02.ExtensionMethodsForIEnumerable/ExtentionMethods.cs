using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtensionMethodsForIEnumerable
{
    public static class ExtentionMethods
    {
        public static T Sum<T>(this IEnumerable<T> items) where T : IComparable
        {
            dynamic result = default(T);

            foreach (var item in items)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> items) where T : IComparable
        {
            dynamic result = 1;

            foreach (var item in items)
            {
                result *= item;
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> items) where T : IComparable
        {
            dynamic result = default(T);

            foreach (var item in items)
            {
                result += item;
            }

            return result / items.Count();
        }

        public static T Min<T>(this IEnumerable<T> items) where T : IComparable
        {
            dynamic result = int.MaxValue;

            foreach (var item in items)
            {
                if (item < result)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> items) where T : IComparable
        {
            dynamic result = int.MinValue;

            foreach (var item in items)
            {
                if (item > result)
                {
                    result = item;
                }
            }

            return result;
        }
    }    
}
