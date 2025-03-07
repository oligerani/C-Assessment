using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAnk
{
    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in Account...");
        }
    }

    // Derived class SavingsAccount overriding CalculateInterest
    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in SavingsAccount...");
        }
    }
}

