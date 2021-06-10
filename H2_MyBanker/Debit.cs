using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public abstract class Debit : Card
    {
        public Debit(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public void PaymentNow()
        {
            Console.WriteLine("When using this card, the money will be withdrawn from the card immediately.");
        }
    }
}
