using System;
using System.Diagnostics;
using CSharp.Functional.Extensions;

namespace CSharpHelper.Helpers
{
    public static class Instrumentation
    {
        public static void Time<T>(this Action act, string opName) =>
             act.ToFunc().Time(opName);


        public static T Time<T>(this Func<T> f, string opName)
        {
            var sw = new Stopwatch();
            sw.Start();
            T t = f();
            sw.Stop();
            Debug.WriteLine($"{opName} took {sw.ElapsedMilliseconds}ms");
            return t;
        }
    }
}
