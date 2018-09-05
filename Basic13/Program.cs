using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Array(int[] arr)
        {
            for(var i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void findMax(int[] arr)
        {
            int max = 0;
            for(var i=0; i<arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        static void getAverage(int[] arr)
        {
            int sum = 0;
            for(var i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum/arr.Length);
        }
        static void greaterThanY(int[] arr, int y)
        {
            int count = 0;
            for(var i=0; i<=arr.Length; i++)
            {
                if(arr[i]>y)
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }
        static void Square(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = arr[i]*arr[i];
                System.Console.WriteLine(arr[i]);
            }
        }
        static void removeNeg(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }
        static void MinMaxAvg(int[] arr){
            int max = arr[0];
            int min = arr[0];
            var sum = 0f;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < min){
                    min = arr[i];
                }
                if(arr[i] > max){
                    max = arr[i];
                }
                sum+=arr[i];
            }
        System.Console.WriteLine(min+" is the min. "+max+" is the max. "+(sum/arr.Length)+" is the average.");
        }
        static void shiftArr(int[] arr){
            for(int i = 0; i < arr.Length-1; i++){
                int temp = arr[i+1];
                arr[i] = temp;
                System.Console.WriteLine(arr[i]);
                }
                arr[arr.Length-1] = 0;
            }

        static void Main(string[] args)
        {
            int sum = 0;  
            for(var i=1; i<= 255; i++)
            {
                Console.WriteLine(i);
            }
            for(var i=1; i<=255; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
            for(var x=0; x<=255; x++)
            {
                sum += x;
                Console.WriteLine("New number: " + x + " Sum: " + sum);
            }
            int[] arr={1,2,3,4,5};
            Array(arr);
            int[] max={1,3,5,6,4,2,8,10};
            findMax(max);
            int[] avg={2,3,10};
            getAverage(avg);
            List<int> oddList = new List<int>(); 
            for(var i=1; i<=255; i++)
            {
                if(i%2!=0)
                {
                    oddList.Add(i);
                    Console.WriteLine(i);
                }
            }
            oddList.ToArray();  
            int[] gtY={1,3,5,7};
            greaterThanY(gtY, 3);
            int[] sqr = {2,4,6,8};
            Square(sqr);
            int[] negs = {2,-4,6,-8};
            removeNeg(negs);
            int[] mma = {1, 5, 10, -2};
            MinMaxAvg(mma);
            int[] shf = {1, 5, 10, 7, -2};
            shiftArr(shf);
            int[] dojonegs = {-1, -3, 2};    
        }
    }
}
