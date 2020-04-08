using System;

namespace Poject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,4,5,8,7,8,9,10};
        }
    }


    //All methods constructed without using List
    /*methods with int parametrs */
    static class ArrayHelper 
    {
        public static int Pop(ref int[] array) 
        {
            int n  = array.Length;
            int del_element = array[n-1];
            int[] arraytohelp = new int[n-1];
            for (int i = 0; i < n-1; i++)
            {
                arraytohelp[i] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int Push(ref int[] array, int new_elem)
        {
            
            int n  = array.Length;
            int[] arraytohelp = new int[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == n)?new_elem:array[i];
            }
            array = arraytohelp;
            return array.Length;
        }
        public static int Shift(ref int[] array) 
        {
            int n  = array.Length;
            int del_element = array[0];
            int[] arraytohelp = new int[n-1];
            for (int i = 1; i < n; i++)
            {
                arraytohelp[i-1] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int UnShift(ref int[] array, int new_elem)
        {
            
            int n  = array.Length;
            int[] arraytohelp = new int[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == 0)?new_elem:array[i-1];
            }
            array = arraytohelp;
            return array.Length;
        }

        



    }
 
}
