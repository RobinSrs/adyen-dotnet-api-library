﻿#region Licence
// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion

using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{/// <summary>
 /// 
 /// </summary>
    [DataContract]
    public class Mandate
    {
        /// <summary>
        /// The billing amount of the recurring transactions.
        /// </summary>
        /// <value>The billing amount of the recurring transactions.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the `amount`.   * **exact**: The transaction amount should be the same as the `amount`.  
        /// </summary>
        /// <value>The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the `amount`.   * **exact**: The transaction amount should be the same as the `amount`.  </value>
        [DataMember(Name = "amountRule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountRule")]
        public string AmountRule { get; set; }

        /// <summary>
        /// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  
        /// </summary>
        /// <value>The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  </value>
        [DataMember(Name = "billingAttemptsRule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAttemptsRule")]
        public string BillingAttemptsRule { get; set; }

        /// <summary>
        /// The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.  Possible values: 1-31 based on the `frequency`.
        /// </summary>
        /// <value>The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.  Possible values: 1-31 based on the `frequency`.</value>
        [DataMember(Name = "billingDay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingDay")]
        public string BillingDay { get; set; }

        /// <summary>
        /// End date of the billing plan, in YYYY-MM-DD format.
        /// </summary>
        /// <value>End date of the billing plan, in YYYY-MM-DD format.</value>
        [DataMember(Name = "endsAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endsAt")]
        public string EndsAt { get; set; }

        /// <summary>
        /// The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.
        /// </summary>
        /// <value>The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// The message shown by UPI to the shopper on the approval screen.
        /// </summary>
        /// <value>The message shown by UPI to the shopper on the approval screen.</value>
        [DataMember(Name = "remarks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.
        /// </summary>
        /// <value>Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.</value>
        [DataMember(Name = "startsAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startsAt")]
        public string StartsAt { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mandate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountRule: ").Append(AmountRule).Append("\n");
            sb.Append("  BillingAttemptsRule: ").Append(BillingAttemptsRule).Append("\n");
            sb.Append("  BillingDay: ").Append(BillingDay).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
