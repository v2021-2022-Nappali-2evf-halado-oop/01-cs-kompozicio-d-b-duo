using SpectatorProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    class Spectator
    {
        private Name name;
        private CreditCard creditCard;
        private BonusCard bonusCard;

        public Spectator(Name name, CreditCard creditCard, BonusCard bonusCard)
        {
            this.name = name;
            this.creditCard = creditCard;
            this.bonusCard = bonusCard;
        }
    }
}
