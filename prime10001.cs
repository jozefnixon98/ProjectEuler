using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialise our list of primes as just 2 and our sum of primes as 2
            Int64 sum = 2;
            List<int> primes = new List<int>();
            primes.Add(2);
            //Check every number below 2000000 to see if it is prime
            for (int nums = 3; nums < 2000000; nums += 2)
            {
                if (Isprime(nums,primes))
                {
                    //If it is prime add to our list and sum
                    primes.Add(nums);
                    sum += nums;
                }
            }
            //Output our sum
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        //This checks if a number is prime
        static bool Isprime(int nums, List<int> primes)
        {
            //Iterate through our list of primes to see if any divide the number we are testing
            for (int i = 0; i < primes.Count; i++)
            {
                if (nums % primes[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
