using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorProject.model
{
    /// <summary>
    /// Státusz enum 
    /// </summary>
    enum Status
    {
        Active,
        Inactive,
        Expired
    }

    /// <summary>
    /// Név osztály létrehozása
    /// </summary>
    class Name
    {
        /// <summary>
        /// keresztnév adattag
        /// </summary>
        string firstName;

        /// <summary>
        /// Vezetéknév adattag
        /// </summary>
        string lastName;

        /// <summary>
        /// Konstruktor létrehozása
        /// </summary>
        /// <param name="lastName">vezetéknév</param>
        /// <param name="firstName">keresztnév</param>
        public Name(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

    }
}
