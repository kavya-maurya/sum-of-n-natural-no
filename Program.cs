using System;
namespace Program 
{
class Program
{
    static void Main(string[]args)
    {
        Console.Write("to calculate sum of first N natural number; please provide value for 'N' here ---> ");
        int N = Convert.ToInt32(Console.ReadLine());

        
         int sum = N*(N+1)/2 ;

         Console.WriteLine($"{sum}");
         

    }
}
}       
