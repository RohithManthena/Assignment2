using System;
using System.Collections.Generic;

namespace _2019_Fall_Assignment2

{

    class Program

    {

        public static void Main(string[] args)

        {

            /*int target =3;

            int[] nums = { 2, 3, 5, 6, 8, 10 };
            int c = SearchInsert(nums, target);
         

            Console.WriteLine("Position to insert {0} is = {1}\n", target, SearchInsert(nums, target));*/
/*            int[] nums1 = { 1, 2, 2, 1,5,5,8,8 };
            int[] nums2 = { 2, 2,5,5,5,5,8 };
            int[] intersect = Intersect(nums1, nums2);

        
            DisplayArray(intersect);
            Console.WriteLine("\n");*/



            /*int[] A = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };

            Console.WriteLine("Largest integer occuring once = {0}\n", LargestUniqueNumber(A));*/


            }

            /*string keyboard = "abcdefghijklmnopqrstuvwxyz";

            string word = "cba";

            Console.WriteLine("Time taken to type with one finger = {0}\n", CalculateTime(keyboard, word));



            int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };

            int[,] flipAndInvertedImage = FlipAndInvertImage(image);

            Console.WriteLine("The resulting flipped and inverted image is:\n");

            Display2DArray(flipAndInvertedImage);

            Console.Write("\n");



            int[,] intervals = { { 0, 30 }, { 5, 10 }, { 15, 20 } };

            int minMeetingRooms = MinMeetingRooms(intervals);

            Console.WriteLine("Minimum meeting rooms needed = {0}\n", minMeetingRooms);



            int[] arr = { -4, -1, 0, 3, 10 };

            int[] sortedSquares = SortedSquares(arr);

            Console.WriteLine("Squares of the array in sorted order is:");

            DisplayArray(sortedSquares);

            Console.Write("\n");



            string s = "abca";

            if (ValidPalindrome(s))
            {

                Console.WriteLine("The given string \"{0}\" can be made PALINDROME", s);

            }

            else

            {

                Console.WriteLine("The given string \"{0}\" CANNOT be made PALINDROME", s);

            }

        }*/



        public static void DisplayArray(int[] a)

        {

            foreach (int n in a)

            {

                Console.Write(n + " ");

            }

        }



        public static void Display2DArray(int[,] a)

        {

            for (int i = 0; i < a.GetLength(0); i++)

            {

                for (int j = 0; j < a.GetLength(1); j++)

                {

                    Console.Write(a[i, j] + "\t");

                }

                Console.Write("\n");

            }

        }



        public static int SearchInsert(int[] nums, int target)

        {

            try

            {

                int len = nums.Length;
                int start = 0;
                int end = len - 1;
                int c = -1;
                


               while (start<=end)
                {
                    int mid = (start + end )/ 2;
                    if (nums[mid] == target )
                    {
                         c=mid;
                        break;
                    }
                    else if (nums[mid] > target)
                    {
                        end = mid - 1;
                        if (mid == 0)
                            c = mid;
                        else if ((nums[mid - 1] < target))
                            c = mid;

                    }
                    else if ((nums[mid] < target))
                    {
                        start = mid + 1;

                        if (mid ==end)
                            c = mid + 1;
                        else if((nums[mid + 1] > target))
                            c = mid+1;
                    }
                    

                }
                return c;

            }

            catch

            {

                Console.WriteLine("Exception occured while computing SearchInsert()");

            }
            return 0;

        }



        public static int[] Intersect(int[] nums1, int[] nums2)

        {
            List<int> result = new List<int>();

            try

            {
                int a = nums1.Length;
                int b = nums2.Length;
                int i = 0;
                int j = 0;
                
                while(i<a&&j<b)
                {
                    if(nums1[i]>nums2[j])
                    {
                        j++;
                    }
                    else if(nums1[i]<nums2[j])
                    {
                        i++;
                    }
                    else
                    {
                        result.Add(nums1[i]);
                        i++;
                        j++;
                    }

                }
            }

            catch

            {

                Console.WriteLine("Exception occured while computing Intersect()");

            }



            return result.ToArray();

        }



        public static int LargestUniqueNumber(int[] A)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing LargestUniqueNumber()");

            }



            return 0;

        }



        public static int CalculateTime(string keyboard, string word)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing CalculateTime()");

            }



            return 0;

        }



        public static int[,] FlipAndInvertImage(int[,] A)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing FlipAndInvertImage()");

            }



            return new int[,] { };

        }



        public static int MinMeetingRooms(int[,] intervals)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing MinMeetingRooms()");

            }



            return 0;

        }



        public static int[] SortedSquares(int[] A)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing SortedSquares()");

            }



            return new int[] { };

        }



        public static bool ValidPalindrome(string s)

        {

            try

            {

                // Write your code here

            }

            catch

            {

                Console.WriteLine("Exception occured while computing ValidPalindrome()");

            }



            return false;

        }

    }

}