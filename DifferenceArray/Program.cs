using System;

namespace DifferenceArray {
    class Program {
        static void Main() {
            int[] aArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            Console.WriteLine("Исходный массив:");
            int nMin = aArr[0]; // Минимальный элемент
            int nMax = aArr[0]; // Максимальный элемент
            int nDifference = 0;    // Для разности
            for (int i = 0; i < aArr.Length; i++) {                
                Console.Write(aArr[i] + " ");
                // Для поиска минимального
                if (nMin > aArr[i]) {
                    nMin = aArr[i];
                }
                // Для поиска максимального
                else {
                    nMax = aArr[i];
                }
            }
            // Разность
            nDifference = nMax - nMin;
            Console.Write($"\nmin: {nMin}\n");
            Console.Write($"max: {nMax}\n");
            Console.Write($"difference: {nDifference}");
            Console.ReadKey();
        }
    }
}
