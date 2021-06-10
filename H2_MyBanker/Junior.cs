using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public class Junior : Debit
    {
        public Junior(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public override int DeterminePrefix()
        {
            int prefix = 2400;

            return prefix;
        }
        public override string GetExpirationDate()
        {
            string noExpirationDate = "NO EXPIRATION DATE";

            return noExpirationDate;
        }
    }
}
