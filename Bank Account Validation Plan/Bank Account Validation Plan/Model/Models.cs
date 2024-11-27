using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Validation_Plan.Model
{
    public class ABAAcctVerificationRequestModel
    {
        public string BankRoutingNumber { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
