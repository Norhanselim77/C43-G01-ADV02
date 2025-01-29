using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

#region MyRegion

//public class GreaterThanX
//{
//    public static void Main(string[] args
//    {
//        string[] input = Console.ReadLine().Split();
//        int n = int.Parse(input[0]); // Size of the array
//        int q = int.Parse(input[1]); // Number of queries

//        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); // Read the array

//        for (int i = 0; i < q; i++)
//        {
//            int x = int.Parse(Console.ReadLine()); // Read the query value X

//            int count = arr.Count(num => num > x); // Count elements greater than X

//            Console.WriteLine(count);
//        }
//    }
//}

#endregion
#region 2- Given a number N and an array of N numbers. Determine if it's palindrome or not.
//public class PalindromeChecker
//{
//    public static bool IsPalindrome(int[] arr)
//    {
//        int n = arr.Length;

//        // Method 1: Using two pointers (most efficient)
//        int left = 0;
//        int right = n - 1;

//        while (left < right)
//        {
//            if (arr[left] != arr[right])
//            {
//                return false; // Not a palindrome
//            }
//            left++;
//            right--;
//        }
//        return true; // It's a palindrome


//        // Method 2: Using Reverse (less efficient for large arrays due to copying)
//        //int[] reversedArr = new int[n];
//        //Array.Copy(arr, reversedArr, n); // Create a copy
//        //Array.Reverse(reversedArr);

//        //return arr.SequenceEqual(reversedArr); // Compare original with reversed


//        // Method 3: Using LINQ Reverse (also less efficient)
//        //return arr.SequenceEqual(arr.Reverse()); // Direct comparison with reversed using LINQ
//    }

//    public static void Main(string[] args)
//    {
//        // Example usage:
//        int[] arr1 = { 1, 2, 3, 2, 1 };
//        int[] arr2 = { 1, 2, 3, 4, 5 };

//        Console.WriteLine($"arr1 is palindrome: {IsPalindrome(arr1)}"); // Output: True
//        Console.WriteLine($"arr2 is palindrome: {IsPalindrome(arr2)}"); // Output: False


//        // Get input from the user (more interactive)
//        Console.WriteLine("Enter the number of elements:");
//        int n = int.Parse(Console.ReadLine());

//        int[] userInputArr = new int[n];
//        Console.WriteLine("Enter the elements separated by spaces:");
//        string[] inputValues = Console.ReadLine().Split(' ');

//        if (inputValues.Length != n)
//        {
//            Console.WriteLine("Incorrect number of inputs.");
//            return; // Exit the program or handle the error appropriately.
//        }

//        for (int i = 0; i < n; i++)
//        {
//            if (int.TryParse(inputValues[i], out int num))
//            {
//                userInputArr[i] = num;
//            }
//            else
//            {
//                Console.WriteLine($"Invalid input '{inputValues[i]}'. Please enter integers only.");
//                return; // Or handle the error as needed.
//            }
//        }

//        Console.WriteLine($"User input is palindrome: {IsPalindrome(userInputArr)}");


//    }
//}

#endregion

#region 3-Given a Queue, implement a function to reverse the elements of a queue using a stack.


//class Program
//{
//    // Function to reverse the elements of a queue using a stack
//    public static void ReverseQueue(Queue<int> queue)
//    {
//        Stack<int> stack = new Stack<int>();

//        // Step 1: Move all elements from the queue to the stack
//        while (queue.Count > 0)
//        {
//            stack.Push(queue.Dequeue());
//        }

//        // Step 2: Move all elements from the stack back to the queue
//        while (stack.Count > 0)
//        {
//            queue.Enqueue(stack.Pop());
//        }
//    }

//    static void Main()
//    {
//        // Sample queue
//        Queue<int> queue = new Queue<int>();
//        queue.Enqueue(1);
//        queue.Enqueue(2);
//        queue.Enqueue(3);
//        queue.Enqueue(4);
//        queue.Enqueue(5);

//        // Print original queue
//        Console.WriteLine("Original Queue: ");
//        foreach (var item in queue)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();

//        // Reverse the queue
//        ReverseQueue(queue);

//        // Print the reversed queue
//        Console.WriteLine("Reversed Queue: ");
//        foreach (var item in queue)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }
//}

#endregion


#region 4-Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

//public class ParenthesesChecker
//{
//    public static bool IsBalanced(string s)
//    {
//        Stack<char> stack = new Stack<char>();

//        foreach (char c in s)
//        {
//            if (c == '(' || c == '{' || c == '[')  // Push opening brackets onto the stack
//            {
//                stack.Push(c);
//            }
//            else if (c == ')' || c == '}' || c == ']')  // Check closing brackets
//            {
//                if (stack.Count == 0)  // If stack is empty, return false
//                    return false;

//                char top = stack.Pop();

//                if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
//                {
//                    return false;  // Mismatch found
//                }
//            }
//        }

//        return stack.Count == 0;  // If stack is empty, parentheses are balanced
//    }

//    public static void Main()
//    {
//        string input = "{[()]}";
//        bool result = IsBalanced(input);
//        Console.WriteLine($"The string is balanced: {result}");
//    }
//}


#endregion

#region 5-Given an array, implement a function to remove duplicate elements from an array.

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 2, 2, 3, 4, 4, 5 };

//        // Remove duplicates
//        int[] uniqueArray = RemoveDuplicates(array);

//        // Display the result
//        Console.WriteLine("Array without duplicates: ");
//        foreach (int item in uniqueArray)
//        {
//            Console.Write(item + " ");
//        }
//    }

//    static int[] RemoveDuplicates(int[] array)
//    {
//        // Use a HashSet to store unique elements
//        HashSet<int> uniqueSet = new HashSet<int>(array);

//        // Convert the HashSet back to an array
//        int[] uniqueArray = new int[uniqueSet.Count];
//        uniqueSet.CopyTo(uniqueArray);

//        return uniqueArray;
//    }
//}

#endregion


#region 6-Given an array list , implement a function to remove all odd numbers from it.

//public class Program
//{
//    public static void RemoveOdds(List<int> numbers)
//    {
//        // Use a reverse loop to avoid index shifting when removing items
//        for (int i = numbers.Count - 1; i >= 0; i--)
//        {
//            if (numbers[i] % 2 != 0) // Check if the number is odd
//            {
//                numbers.RemoveAt(i); // Remove the odd number
//            }
//        }
//    }

//    public static void Main()
//    {
//        // Example usage
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        Console.WriteLine("Original list:");
//        numbers.ForEach(n => Console.Write(n + " "));

//        RemoveOdds(numbers);

//        Console.WriteLine("\nList after removing odd numbers:");
//        numbers.ForEach(n => Console.Write(n + " "));
//    }
//}


#endregion
#region 7-Implement a queue that can hold different data types. 
//And insert the following data:
//queue.Enqueue(1)
//queue.Enqueue(“Apple”)
//queue.Enqueue(5.28)

//class Program
//{
//    static void Main()
//    {
//        // Create a queue that can hold any type of data (object type)
//        Queue<object> queue = new Queue<object>();

//        // Enqueue different types of data
//        queue.Enqueue(1);           // Integer
//        queue.Enqueue("Apple");     // String
//        queue.Enqueue(5.28);        // Double

//        // Dequeue and display the data
//        while (queue.Count > 0)
//        {
//            object item = queue.Dequeue();
//            Console.WriteLine(item);
//        }
//    }
//}



#endregion
#region 8-Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found,
//print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

//class Program
//{
//    static void Main(string[] args)
//    {
//        Stack<int> stack = new Stack<int>();

//        // Push a series of integers onto the stack
//        PushIntegersToStack(stack, new int[] { 10, 20, 30, 40, 50 });

//        // Define the target integer to search for
//        int target = 30;

//        // Search for the target in the stack
//        SearchTargetInStack(stack, target);
//    }

//    // Function to push integers onto the stack
//    static void PushIntegersToStack(Stack<int> stack, int[] numbers)
//    {
//        foreach (var number in numbers)
//        {
//            stack.Push(number);
//        }
//    }

//    // Function to search for a target in the stack
//    static void SearchTargetInStack(Stack<int> stack, int target)
//    {
//        int checkCount = 0;

//        // Create a temporary stack to preserve the original stack
//        Stack<int> tempStack = new Stack<int>(stack);

//        // Loop through the stack to check for the target
//        while (tempStack.Count > 0)
//        {
//            checkCount++;
//            int currentElement = tempStack.Pop();

//            if (currentElement == target)
//            {
//                Console.WriteLine($"Target was found successfully and the count = {checkCount}");
//                return;
//            }
//        }

//        // If target is not found
//        Console.WriteLine("Target was not found");
//    }
//}

#endregion

#region 9-Given two arrays, find their intersection.
/*ach element in the result should appear as many times as it shows in both arrays.*/

//class Program
//{
//    static void Main()
//    {
//        // Example arrays
//        int[] array1 = { 1, 2, 2, 1, 3 };
//        int[] array2 = { 2, 2, 3, 3 };

//        // Find the intersection where each element appears as many times as it appears in both arrays
//        var intersection = array1.Intersect(array2).ToArray();

//        Console.WriteLine("Intersection:");
//        foreach (var num in intersection)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}

#endregion

#region 10-
//Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

//public class Solution
//{
//    public static bool HasSublistWithSum(List<int> nums, int target)
//    {
//        int currentSum = 0;
//        int start = 0;

//        // Traverse through the list with the end pointer
//        for (int end = 0; end < nums.Count; end++)
//        {
//            currentSum += nums[end];

//            // If currentSum exceeds the target, move the start pointer to reduce the sum
//            while (currentSum > target && start <= end)
//            {
//                currentSum -= nums[start];
//                start++;
//            }

//            // Check if we have found a sublist with the target sum
//            if (currentSum == target)
//            {
//                return true;
//            }
//        }

//        // Return false if no such sublist is found
//        return false;
//    }

//    public static void Main(string[] args)
//    {
//        List<int> nums = new List<int> { 1, 2, 3, 7, 5 };
//        int target = 12;

//        bool result = HasSublistWithSum(nums, target);
//        Console.WriteLine("Sublist with target sum exists: " + result);
//    }
//}



#endregion


#region 11-Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

//public class QueueReversal
//{
//    public static void ReverseFirstKElements(Queue<int> queue, int k)
//    {
//        if (queue == null || k <= 0 || k > queue.Count)
//            return;

//        Stack<int> stack = new Stack<int>();

//        // Step 1: Dequeue the first K elements and push them to the stack
//        for (int i = 0; i < k; i++)
//        {
//            stack.Push(queue.Dequeue());
//        }

//        // Step 2: Enqueue the elements from the stack back into the queue
//        while (stack.Count > 0)
//        {
//            queue.Enqueue(stack.Pop());
//        }

//        // Step 3: Move the remaining elements (from position k to the end) to the back
//        int remainingElements = queue.Count - k;
//        for (int i = 0; i < remainingElements; i++)
//        {
//            queue.Enqueue(queue.Dequeue());
//        }
//    }

//    public static void PrintQueue(Queue<int> queue)
//    {
//        foreach (var item in queue)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }

//    public static void Main()
//    {
//        Queue<int> queue = new Queue<int>();
//        queue.Enqueue(1);
//        queue.Enqueue(2);
//        queue.Enqueue(3);
//        queue.Enqueue(4);
//        queue.Enqueue(5);

//        Console.WriteLine("Original Queue:");
//        PrintQueue(queue);

//        int k = 3;
//        ReverseFirstKElements(queue, k);

//        Console.WriteLine($"Queue after reversing first {k} elements:");
//        PrintQueue(queue);
//    }
//}

#endregion