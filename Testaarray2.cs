using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int []  n = new int[20]; /* n is an array of 20 integers */
         int i,j;

         for ( i = 0; i < 20; i++ ) {
            n[ i ] = i ;
         }
         
         for (j = 0; j < 20; j++ ) {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadKey();
      }
   }
}
