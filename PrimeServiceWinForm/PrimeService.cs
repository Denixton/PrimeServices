using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeServices
{
    public class PrimeService
    {
        public bool IsPrime(int n)
        { 
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

            return true;
        }
    }
}
