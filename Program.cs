using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace SortTool
{
    class Program
    {
        static void Main(string[] args)
        {
            SortToolLibrary sortObject = new SortToolLibrary();
            List<string> runList = new List<string>() { "InsertionSort", "BubbleSort", "MergeSort", "SelectionSort", "QuickSort" };
            const BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
            var methodList = new List<MethodInfo>(sortObject.GetType().GetMethods(flags)).Where(x =>
            {
                foreach (string run in runList)
                {
                    if (x.Name == run)
                        return true;
                }
                return false;
            }).ToList();
            List<KeyValuePair<string, TimeSpan>> compare = new List<KeyValuePair<string, TimeSpan>>();
            foreach (var info in methodList)
            {
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                info.Invoke(sortObject, null);
                sw.Stop();
                TimeSpan el = sw.Elapsed;
                long ms = sw.ElapsedMilliseconds;
                sortObject.TimeSpan(ms, info.Name);
                sortObject.PrintOut();
                sortObject.Reset();
                compare.Add(new KeyValuePair<string, TimeSpan>(info.Name, el));
            }
            sortObject.ComparePrintOut(compare);
        }
    }
}