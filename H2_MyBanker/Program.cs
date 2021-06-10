using System;

namespace H2_MyBanker
{
    class Program
    {
        static Random random = new Random();
        static string[] firstNames = new string[] { "John ", "Ben ", "Cecile ", "Amanda ", "Jeff ", "Aaron ", "Eliza ", "Alexa ", "Bob ", "Laila " };
        static string[] lastNames = new string[] { "Hancock", "Bezoz", "Anderson", "Smith", "Hendrix", "Finkle", "Mathers", "Allen", "West", "Wayne" };

        static void Main(string[] args)
        {
            string name1 = CustomerName();
            string name2 = CustomerName();
            string name3 = CustomerName();
            string name4 = CustomerName();
            string name5 = CustomerName();

            Card junior = new Junior(0, 0, 0, name1);
            junior.Prefix = junior.DeterminePrefix();
            junior.CardNumber = junior.GenerateCardNumber(junior.Prefix);
            junior.AccountNumber = junior.GenerateAccountNumber();

            Card maestro = new Maestro(0, 0, 0, name2);
            maestro.Prefix = maestro.DeterminePrefix();
            maestro.CardNumber = maestro.GenerateCardNumber(maestro.Prefix);
            maestro.AccountNumber = maestro.GenerateAccountNumber();

            Card visaElectron = new VisaElectron(0, 0, 0, name3);
            visaElectron.Prefix = visaElectron.DeterminePrefix();
            visaElectron.CardNumber = visaElectron.GenerateCardNumber(visaElectron.Prefix);
            visaElectron.AccountNumber = visaElectron.GenerateAccountNumber();

            Card visaDk = new VisaDK(0, 0, 0, name4);
            visaDk.Prefix = visaDk.DeterminePrefix();
            visaDk.CardNumber = visaDk.GenerateCardNumber(visaDk.Prefix);
            visaDk.AccountNumber = visaDk.GenerateAccountNumber();

            Card master = new Master(0, 0, 0, name5);
            master.Prefix = master.DeterminePrefix();
            master.CardNumber = master.GenerateCardNumber(master.Prefix);
            master.AccountNumber = master.GenerateAccountNumber();

            Console.WriteLine(junior.ToString());
            Console.WriteLine(maestro.ToString());
            Console.WriteLine(visaElectron.ToString());
            Console.WriteLine(visaDk.ToString());
            Console.WriteLine(master.ToString());
        }

        static string CustomerName()
        {
            string tempName = firstNames[(random.Next(0, 10))];
            tempName += lastNames[(random.Next(0, 10))];

            return tempName;
        }
    }
}
