using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    class CreditCard
    {
        private DateTime expireDate;
        private string cardNumber;

        public CreditCard(DateTime expireDate, string cardNumber)
        {
            this.expireDate = expireDate;
            this.cardNumber = cardNumber;
        }
    }
}
