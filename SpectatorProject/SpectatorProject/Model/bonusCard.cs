using SpectatorProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.Model
{
    class BonusCard
    {
        private float budget;
        private string cardNumber;
        private Status cardStatus;

        public BonusCard(float budget, string cardNumber, Status cardStatus)
        {
            this.budget = budget;
            this.cardNumber = cardNumber;
            this.cardStatus = cardStatus;
        }

    }
}
