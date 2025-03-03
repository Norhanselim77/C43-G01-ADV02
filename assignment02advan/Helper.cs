using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02advan
{
    internal class Helper
    {
        #region 1
        public static void PrintHowManyNumsGreaterThanX(int[] arr, int X)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > X)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
        #endregion

        #region 2

        public static bool IfItIsPalindrome(int[] arr, int X)
        {
            for (int i = 0; i < X / 2; i++)
            {
                if (arr[i] != arr[X - i - 1])
                    return false;
            }
            return true;
        }
        #endregion

        #region 3

        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> tempStack = new Stack<T>();
            while (queue.Count > 0)
            {
                tempStack.Push(queue.Dequeue());
            }
            while (tempStack.Count > 0)
            {
                queue.Enqueue(tempStack.Pop());
            }
        }
        #endregion

        #region 4
        public static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region 5

        public static void RemoveDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[j] = -1;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    break;
                }
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region 6

        public static void RemoveOddNumbers(ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if ((int?)array[i] % 2 != 0)
                {
                    array.RemoveAt(i);
                    i--;
                }
            }
        }

        #endregion

        #region 8

        public static void CheckTargetSum<T>(Stack<T> stack, T Target)
        {
            foreach (T item in stack)
            {
                if (item.Equals(Target))
                {
                    Console.WriteLine($"Target was found successfully and the count = {stack.Count - 1}");
                    return;
                }
            }
            Console.WriteLine("Target was not found");
        }

        #endregion

        #region 9

        public static int[] GetIntersection(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        list.Add(arr1[i]);
                        break;
                    }
                }
            }
            return list.ToArray();
        }

        #endregion

        #region 10

        public static List<int> TargetSum(ArrayList array, int target)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if ((int)array[i] + (int)array[j] == target)
                    {
                        list.Add((int)array[i]);
                        list.Add((int)array[j]);
                        break;
                    }
                }
            }
            return list;
        }
        #endregion

        #region 11
        public static void reverseQueueFirstKElements<T>(Queue<T> queue, int k)
        {
            if (queue.Count == 0 || k > queue.Count)
            {
                return;
            }
            if (k <= 0)
            {
                return;
            }
            Stack<T> stack = new Stack<T>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
        #endregion
    }
}