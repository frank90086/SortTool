using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTool
{
    public class SortToolLibrary
    {
        public List<int> _list { get; set; }
        public List<int> SortList { get; set; }
        public SortToolLibrary()
        {
            _list = new List<int>() { 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75,1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75 };
            SortList = new List<int>();
        }

        public void Reset()
        {
            _list = new List<int>() { 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75,1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75, 1, 6, 44, 32, 2, 9, 28, -2, 20, 0, 75 };
            SortList = new List<int>();
        }

        public void PrintOut()
        {
            foreach (int item in SortList)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void TimeSpan(long ms, string methodName)
        {
            Console.WriteLine("The {0} Sort Time: {1}毫秒", methodName, ms);
        }

        public void ComparePrintOut(List<KeyValuePair<string, TimeSpan>> compare)
        {
            compare.Sort((x, y) => x.Value.CompareTo(y.Value));
            foreach (var item in compare)
            {
                Console.Write("{0} ", item.Key);
                if (!item.Equals(compare.LastOrDefault()))
                    Console.Write("> ");
            }
        }

        public void InsertionSort()
        {
            if (_list.Count > 0)
            {
                int value = _list.FirstOrDefault();
                _list.Remove(value);
                if (SortList.Count > 0)
                {
                    bool added = false;
                    foreach (int item in SortList.ToList())
                    {
                        if (value < item)
                        {
                            SortList.Insert(SortList.IndexOf(item), value);
                            added = true;
                            break;
                        }
                    }
                    if (!added)
                        SortList.Add(value);
                }
                else
                {
                    SortList.Add(value);
                }

                InsertionSort();
            }
        }

        public void BubbleSort()
        {
            _list.Sort((x, y) => x.CompareTo(y));
            SortList = _list;
        }

        public void MergeSort()
        {
            List<List<int>> mergeList = new List<List<int>>();
            for (int i = 0; i < _list.Count; i++)
            {
                mergeList.Add(new List<int>() { _list[i] });
            }
            buttomUpSort(mergeList);
        }

        private void buttomUpSort(List<List<int>> mergeList)
        {
            List<List<int>> sortResult = new List<List<int>>();
            for (int i = 0; i < mergeList.Count; i += 2)
            {
                if (i == mergeList.Count - 1)
                    sortResult.Add(mergeList[i]);
                else
                    sortResult.Add(mergeSort(mergeList[i], mergeList[i + 1]));
            }
            if (sortResult.Count == 1)
                SortList = sortResult.FirstOrDefault();
            else
                buttomUpSort(sortResult);
        }

        private List<int> mergeSort(List<int> leftList, List<int> rightList)
        {
            List<int> sortList = new List<int>();
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                int leftInt = 0, rightInt = 0;
                if (leftList.Count > 0)
                    leftInt = leftList.FirstOrDefault();
                if (rightList.Count > 0)
                    rightInt = rightList.FirstOrDefault();
                if (leftInt <= rightInt && leftList.Count != 0 || rightList.Count == 0)
                {
                    sortList.Add(leftInt);
                    leftList.Remove(leftInt);
                }
                else
                {
                    sortList.Add(rightInt);
                    rightList.Remove(rightInt);
                }
            }
            return sortList;
        }

        public void SelectionSort()
        {
            selectionSort(_list);
        }

        private void selectionSort(List<int> list, int count = 0)
        {
            int minInt = list[count];
            int index = 0;
            for (var i = count; i < list.Count; i++)
            {
                if (i + 1 > list.Count - 1)
                    break;
                if (minInt > list[i + 1])
                {
                    minInt = list[i + 1];
                    index = i + 1;
                }
            }
            if (index != 0)
            {
                list.RemoveAt(index);
                list.Insert(count, minInt);
            }
            count++;
            if (count == list.Count - 1)
                SortList = list;
            else
                selectionSort(list, count);
        }

        public void QuickSort()
        {
            quickSort(_list, 0, _list.Count - 1);
        }

        private void quickSort(List<int> list, int startIndex, int pivot)
        {
            bool isSameList = true;
            for (int i = startIndex; i < pivot; i++)
            {
                if (list[i] > list[pivot])
                {
                    int moveValue = list[i];
                    list.RemoveAt(i);
                    list.Insert(pivot, moveValue);
                    i -= 1;
                    pivot -= 1;
                    isSameList = false;
                }
            }
            if (!isSameList)
            {
                quickSort(list, 0, pivot - 1);
                quickSort(list, pivot + 1, list.Count - 1);
            }
            else if (pivot - 1 > 0)
                quickSort(list, 0, pivot - 1);
            else
                SortList = list;
        }
    }
}