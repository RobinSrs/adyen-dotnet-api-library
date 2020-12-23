using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GooglePayDetails {
    /// <summary>
    /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
    /// </summary>
    /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// Gets or Sets GooglePayCardNetwork
    /// </summary>
    [DataMember(Name="googlePayCardNetwork", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "googlePayCardNetwork")]
    public string GooglePayCardNetwork { get; set; }

    /// <summary>
    /// Gets or Sets GooglePayToken
    /// </summary>
    [DataMember(Name="googlePayToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "googlePayToken")]
    public string GooglePayToken { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailReference")]
    public string RecurringDetailReference { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethodId")]
    public string StoredPaymentMethodId { get; set; }

    /// <summary>
    /// **paywithgoogle**
    /// </summary>
    /// <value>**paywithgoogle**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GooglePayDetails {\n");
      sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
      sb.Append("  GooglePayCardNetwork: ").Append(GooglePayCardNetwork).Append("\n");
      sb.Append("  GooglePayToken: ").Append(GooglePayToken).Append("\n");
      sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
      sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}