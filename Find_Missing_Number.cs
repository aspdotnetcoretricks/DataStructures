using System;

namespace Find_Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10 };

           int total = (size.Length+1)*(size.Length+2)/2;
            int totalSize = 0;
            for (int i=0; i<=size.Length-1;i++)
            {
                totalSize = totalSize + size[i];
            }
            int MissingNumber = total - totalSize;
            Console.WriteLine("The Missing Number is +"+MissingNumber);
            Console.ReadLine();
        
        }
        
    }
}
