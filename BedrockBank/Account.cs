﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// This class provides definition for an account for BedRock bank
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Balance of the account
        /// </summary>
        public decimal Balance { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}