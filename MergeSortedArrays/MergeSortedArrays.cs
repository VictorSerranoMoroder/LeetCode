using System;
using System.Collections.Generic;

class MergeSortedArrays
{
    public static void Main() {
        int [] array1 = {2,0};
        int [] array2 = {1};
        int n1 = 6;
        int n2 = 3;
        Merge(array1, array1.Length, array2, array2.Length);

        for (int i = 0; i < array1.Length; i++)
            Console.Write(array1[i]);
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = 0;
        int j = 0;

        List<int> list = new List<int>();

        while (i < m || j < n) {
            
            if  (i < m && j < n) {
                if (nums1[i] < nums2[j]) {
                    list.Add(nums1[i]);
                    i++;
                }
                else {
                    list.Add(nums2[j]);
                    j++;
                }
            }
            else if (i < m) {
                list.Add(nums1[i]);
                i++;
            }
            else if (j < n) {
                list.Add(nums2[j]);
                j++;
            }
        }
        list.CopyTo(nums1,0);
    }
}