using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public class Maestro : Debit, IInternational
    {
        static Random random = new Random();
        static int[] prefixArray = new int[] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };

        public Maestro(int prefix, ulong cardNumber, ulong accountNumber, string name) : base(prefix, cardNumber, accountNumber, name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public override int DeterminePrefix()
        {
            int tempRandom = random.Next(0, prefixArray.Length);
            int prefix = prefixArray[tempRandom];

            return prefix;
        }
        public override ulong GenerateCardNumber(int prefix)
        {
            string cardNumberInProgress = prefix.ToString();

            for (int i = 0; i < 15; i++)
            {
                cardNumberInProgress += random.Next(0, 10);
            }

            ulong generatedCardNumber = ulong.Parse(cardNumberInProgress);

            return generatedCardNumber;
        }

        public override string GetExpirationDate()
        {
            DateTime expirationDate = DateTime.Now;
            expirationDate = expirationDate.AddMonths(68);

            return expirationDate.ToShortDateString();
        }

        bool IInternational.InternationalUsage()
        {
            Console.WriteLine("This card is valid for international use");

            return true;
        }
    }
}
