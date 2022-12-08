using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 16. Даны два одномерных массива А и В: а1, а2, ... , аn и b1, b2, ..., bn. 
    Преобразовать массив В по правилу: если а[i] > 0, то b[i] увеличить в 10 раз, 
    иначе bi заменить 0 (i = 1...n). */

namespace Lab_4_1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, -2, 3, -4, 5, -6, 7, -8, 9};
            int[] B = { 5, 7, -9, 4, 12, -31, -8, 21, 100 };

            for (int i = 0; i < A.Length; i++)            
                if (A[i] > 0)                
                    B[i] = B[i] * 10;                
                else
                    B[i] = 0;
            foreach (var item in B)            
                Console.Write(item + " ");
            Console.ReadKey();
        }
    }
}
