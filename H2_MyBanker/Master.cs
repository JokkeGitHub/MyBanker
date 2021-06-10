using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public class Master : Card, ICredit
    {
        static int[] prefixArray = new int[] { 51, 52, 53, 54, 55 };
        static int dailyWithdrawalLimit = 5000;

        public Master(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
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

        public bool CheckDailyWithdrawalLimit(int withdrawalRequest)
        {
            bool requestAccepted;
            int totalWithdrawnToday = 2500;

            if (totalWithdrawnToday + withdrawalRequest < dailyWithdrawalLimit)
            {
                requestAccepted = true;
            }
            else
            {
                requestAccepted = false;
            }

            return requestAccepted;
        }

        int ICredit.CreditLimit()
        {
            int creditLimit = 40000;

            return creditLimit;
        }

        int ICredit.MonthlyWithdrawalLimit()
        {
            int monthlyWithdrawalLimit = 30000;

            return monthlyWithdrawalLimit;
        }
    }
}
