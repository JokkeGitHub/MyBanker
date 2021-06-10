using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public class VisaElectron : Debit, IInternational
    {
        static int[] prefixArray = new int[] { 4026, 417500, 4508, 4844, 4913, 4917 };
        static int monthlySpendingLimit = 10000;

        public VisaElectron(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public override int DeterminePrefix()
        {
            Random random = new Random();
            int tempRandom = random.Next(0, prefixArray.Length);
            int prefix = prefixArray[tempRandom];

            return prefix;
        }

        public bool CheckMonthlySpendingLimit(int paymentRequest)
        {
            bool requestAccepted;
            int totalSpendThisMonth = 2500;

            if (totalSpendThisMonth + paymentRequest < monthlySpendingLimit)
            {
                requestAccepted = true;
            }
            else
            {
                requestAccepted = false;
            }

            return requestAccepted;
        }

        bool IInternational.InternationalUsage()
        {
            Console.WriteLine("This card is valid for international use");

            return true;
        }
    }
}
