using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace sort_an_array_test
{
    public delegate bool CompareFunc<in T>(T obj1, T obj2);

    class LambdaComparer<T> : IComparer
    {
        private readonly CompareFunc<T> _compareFunc;

        public LambdaComparer(CompareFunc<T> compareFunc)
        {
            _compareFunc = compareFunc;
        }

        public int Compare(object x, object y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (!(x is T t1) || !(y is T t2))
            {
                return -1;
            }

            return _compareFunc(t1, t2) ? 0 : 1;
        }
    }
}
