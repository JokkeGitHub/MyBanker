using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_MyBanker
{
    interface ICredit
    {
        int CreditLimit();
        int MonthlyWithdrawalLimit();
    }
}
