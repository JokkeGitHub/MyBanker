using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public class VisaDK : Debit, ICredit
    {
        public VisaDK(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public override int DeterminePrefix()
        {
            int prefix = 4;

            return prefix;
        }
        int ICredit.CreditLimit()
        {
            int creditLimit = 20000;

            return creditLimit;
        }

        int ICredit.MonthlyWithdrawalLimit()
        {
            int monthlyWithdrawalLimit = 25000;

            return monthlyWithdrawalLimit;
        }
    }
}
