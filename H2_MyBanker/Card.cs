using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    public abstract class Card
    {
        static Random random = new Random();
        static int registrationNumber = 3520;

        private int _prefix;
        private ulong _cardNumber;
        private ulong _accountNumber;
        private string _name;

        public int Prefix
        {
            get
            {
                return this._prefix;
            }
            set
            {
                this._prefix = value;
            }
        }

        public ulong CardNumber
        {
            get
            {
                return this._cardNumber;
            }
            set
            {
                this._cardNumber = value;
            }
        }

        public ulong AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
            set
            {
                this._accountNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public Card(int prefix, ulong cardNumber, ulong accountNumber, string name)
        {
            Prefix = prefix;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            Name = name;
        }

        public abstract int DeterminePrefix();

        public virtual ulong GenerateCardNumber(int prefix)
        {
            string cardNumberInProgress = prefix.ToString();

            for (int i = 0; i < 16 - prefix.ToString().Count(); i++)
            {
                cardNumberInProgress += random.Next(0, 10).ToString();
            }

            ulong generatedCardNumber = ulong.Parse(cardNumberInProgress);

            return generatedCardNumber;
        }

        public ulong GenerateAccountNumber()
        {
            string accountNumberInProgress = registrationNumber.ToString();

            for (int i = 0; i < 10; i++)
            {
                accountNumberInProgress += random.Next(0, 10);
            }

            ulong generatedAccountNumber = ulong.Parse(accountNumberInProgress);

            return generatedAccountNumber;
        }

        public virtual string GetExpirationDate()
        {
            DateTime expirationDate = DateTime.Now;
            expirationDate = expirationDate.AddMonths(60);

            return expirationDate.ToShortDateString();
        }

        public override string ToString()
        {
            string cardInfo = $"_______________________ \n {Name}\n {CardNumber}\n {GetExpirationDate()}\n {AccountNumber}\n_______________________";
            return cardInfo;
        }
    }
}
