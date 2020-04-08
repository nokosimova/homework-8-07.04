using System;

namespace Poject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Please, choose the number of data type you prefer to work with:");
            Console.WriteLine("int     - 1");
            Console.WriteLine("string  - 2");
            Console.WriteLine("double   - 3");
            Console.WriteLine("decimal - 4");            
            Console.WriteLine("float   - 5");
            int type_of_data = int.Parse(Console.ReadLine());
            Console.Write("Initial array :");
            switch(type_of_data)
            {
                case 1:
                {
                    int[] array = new int[10];
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = random.Next(-10,10);
                        Console.Write($"{array[i]} ");
                    }
                    Console.WriteLine("\n Array after Pop method: ");
                    ArrayHelper.Pop(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                                    
                    Console.WriteLine("\n Array after Pushing element 100: ");
                    int n = ArrayHelper.Push(ref array, 100);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{array[i]} ");
                    
                    Console.WriteLine("\n Array after Shift method: ");
                    ArrayHelper.Shift(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                
                    Console.WriteLine("\n Array after UnShift element 100: ");
                    n = ArrayHelper.UnShift(ref array,100);
                    for (int i = 0; i < n; i++)
                        Console.Write($"{array[i]} ");
                }
                    break;
                case 2:
                {
                    string[] array = {"a", "b", "c", "d", "e",
                                      "f", "g", "h", "j", "k"};
                    for(int i = 0; i < 10; i++)
                        Console.Write($"{array[i]} ");
                    Console.WriteLine("\n Array after Pop method: ");
                    ArrayHelper.Pop(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                                    
                    Console.WriteLine("\n Array after Pushing element 100: ");
                    for (int i = 0; i < ArrayHelper.Push(ref array, "100"); i++)
                        Console.Write($"{array[i]} ");
                    
                    Console.WriteLine("\n Array after Shift method: ");
                    ArrayHelper.Shift(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                
                    Console.WriteLine("\n Array after UnShift element 101: ");
                    for (int i = 0; i < ArrayHelper.UnShift(ref array,"101"); i++)
                        Console.Write($"{array[i]} ");
                }
                    break;
                case 3:
                {
                    double[] array = new double[10];
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = random.Next(-10,10);
                        Console.Write($"{array[i]} ");
                    Console.WriteLine("\n Array after Pop method: ");
                    ArrayHelper.Pop(ref array);
                    for (i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                                    
                    Console.WriteLine("\n Array after Pushing element 100: ");
                    for (i = 0; i < ArrayHelper.Push(ref array, 100); i++)
                        Console.Write($"{array[i]} ");
                    
                    Console.WriteLine("\n Array after Shift method: ");
                    ArrayHelper.Shift(ref array);
                    for (i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                
                    Console.WriteLine("\n Array after UnShift element 101: ");
                    for (i = 0; i < ArrayHelper.UnShift(ref array,101); i++)
                        Console.Write($"{array[i]} ");
                    }
                }
                    break;
                case 4:
                {
                    decimal[] array = new decimal[10];
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = random.Next(-10,10);
                        Console.Write($"{array[i]} ");
                    }
                                        Console.WriteLine("\n Array after Pop method: ");
                    ArrayHelper.Pop(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                                    
                    Console.WriteLine("\n Array after Pushing element 100: ");
                    for (int i = 0; i < ArrayHelper.Push(ref array, 100); i++)
                        Console.Write($"{array[i]} ");
                    
                    Console.WriteLine("\n Array after Shift method: ");
                    ArrayHelper.Shift(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                
                    Console.WriteLine("\n Array after UnShift element 101: ");
                    for (int i = 0; i < ArrayHelper.UnShift(ref array,101); i++)
                        Console.Write($"{array[i]} ");
                    
                }
                    break;
                case 5:
                {
                    float[] array = new float[10];
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = random.Next(-10,10);
                        Console.Write($"{array[i]} ");
                    }
                                        Console.WriteLine("\n Array after Pop method: ");
                    ArrayHelper.Pop(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                                    
                    Console.WriteLine("\n Array after Pushing element 100: ");
                    for (int i = 0; i < ArrayHelper.Push(ref array, 100); i++)
                        Console.Write($"{array[i]} ");
                    
                    Console.WriteLine("\n Array after Shift method: ");
                    ArrayHelper.Shift(ref array);
                    for (int i = 0; i < 9; i++)
                        Console.Write($"{array[i]} ");
                
                    Console.WriteLine("\n Array after UnShift element 101: ");
                    for (int i = 0; i < ArrayHelper.UnShift(ref array,101); i++)
                        Console.Write($"{array[i]} ");
                }
                    break;             
                default:
                    Console.WriteLine("Incorrect enter, try again");
                break;
            }
        }
    }


    //All methods constructed without using List
    /*methods with INT parameters */
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

        /*methods with STRING parameters */
        public static string Pop(ref string[] array) 
        {
            int n  = array.Length;
            string del_element = array[n-1];
            string[] arraytohelp = new string[n-1];
            for (int i = 0; i < n-1; i++)
            {
                arraytohelp[i] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int Push(ref string[] array, string new_elem)
        {
            
            int n  = array.Length;
            string[] arraytohelp = new string[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == n)?new_elem:array[i];
            }
            array = arraytohelp;
            return array.Length;
        }
        public static string Shift(ref string[] array) 
        {
            int n  = array.Length;
            string del_element = array[0];
            string[] arraytohelp = new string[n-1];
            for (int i = 1; i < n; i++)
            {
                arraytohelp[i-1] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int UnShift(ref string[] array, string new_elem)
        {
            
            int n  = array.Length;
            string[] arraytohelp = new string[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == 0)?new_elem:array[i-1];
            }
            array = arraytohelp;
            return array.Length;
        }

        /*methods with DOUBLE parameters */
        public static double Pop(ref double[] array) 
        {
            int n  = array.Length;
            double del_element = array[n-1];
            double[] arraytohelp = new double[n-1];
            for (int i = 0; i < n-1; i++)
            {
                arraytohelp[i] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int Push(ref double[] array, double new_elem)
        {
            
            int n  = array.Length;
            double[] arraytohelp = new double[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == n)?new_elem:array[i];
            }
            array = arraytohelp;
            return array.Length;
        }
        public static double Shift(ref double[] array) 
        {
            int n  = array.Length;
            double del_element = array[0];
            double[] arraytohelp = new double[n-1];
            for (int i = 1; i < n; i++)
            {
                arraytohelp[i-1] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static int UnShift(ref double[] array, double new_elem)
        {
            
            int n  = array.Length;
            double[] arraytohelp = new double[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == 0)?new_elem:array[i-1];
            }
            array = arraytohelp;
            return array.Length;
        }
        /*methods with DECIMAL parameters */
        public static decimal Pop(ref decimal[] array) 
        {
            int n  = array.Length;
            decimal del_element = array[n-1];
            decimal[] arraytohelp = new decimal[n-1];
            for (int i = 0; i < n-1; i++)
            {
                arraytohelp[i] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static decimal Push(ref decimal[] array, decimal new_elem)
        {
            
            int n  = array.Length;
            decimal[] arraytohelp = new decimal[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == n)?new_elem:array[i];
            }
            array = arraytohelp;
            return array.Length;
        }
        public static decimal Shift(ref decimal[] array) 
        {
            int n  = array.Length;
            decimal del_element = array[0];
            decimal[] arraytohelp = new decimal[n-1];
            for (int i = 1; i < n; i++)
            {
                arraytohelp[i-1] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static decimal UnShift(ref decimal[] array, decimal new_elem)
        {
            
            int n  = array.Length;
            decimal[] arraytohelp = new decimal[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == 0)?new_elem:array[i-1];
            }
            array = arraytohelp;
            return array.Length;
        }
        /*methods with FLOAT parameters */
        public static float Pop(ref float[] array) 
        {
            int n  = array.Length;
            float del_element = array[n-1];
            float[] arraytohelp = new float[n-1];
            for (int i = 0; i < n-1; i++)
            {
                arraytohelp[i] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static float Push(ref float[] array, float new_elem)
        {
            
            int n  = array.Length;
            float[] arraytohelp = new float[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == n)?new_elem:array[i];
            }
            array = arraytohelp;
            return array.Length;
        }
        public static float Shift(ref float[] array) 
        {
            int n  = array.Length;
            float del_element = array[0];
            float[] arraytohelp = new float[n-1];
            for (int i = 1; i < n; i++)
            {
                arraytohelp[i-1] = array[i];
            }
            array = arraytohelp;
            return del_element;
        }
        public static float UnShift(ref float[] array, float new_elem)
        {
            
            int n  = array.Length;
            float[] arraytohelp = new float[n+1];
            for (int i = 0; i < n+1; i++)
            {
                arraytohelp[i] = (i == 0)?new_elem:array[i-1];
            }
            array = arraytohelp;
            return array.Length;
        }
    }
}
