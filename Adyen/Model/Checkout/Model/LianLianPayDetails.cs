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
  public class LianLianPayDetails {
    /// <summary>
    /// Gets or Sets TelephoneNumber
    /// </summary>
    [DataMember(Name="telephoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "telephoneNumber")]
    public string TelephoneNumber { get; set; }

    /// <summary>
    /// **lianlianpay**
    /// </summary>
    /// <value>**lianlianpay**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LianLianPayDetails {\n");
      sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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