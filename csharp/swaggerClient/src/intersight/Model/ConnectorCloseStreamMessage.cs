/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-228
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = intersight.Client.SwaggerDateConverter;

namespace intersight.Model
{
    /// <summary>
    /// Close a running stream. After close the stream will no longer emit events or be available to write to. 
    /// </summary>
    [DataContract]
    public partial class ConnectorCloseStreamMessage :  IEquatable<ConnectorCloseStreamMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorCloseStreamMessage" /> class.
        /// </summary>
        /// <param name="StreamName">The requested stream name. Stream names are unique per device endpoint.   .</param>
        public ConnectorCloseStreamMessage(string StreamName = default(string))
        {
            this.StreamName = StreamName;
        }
        
        /// <summary>
        /// The requested stream name. Stream names are unique per device endpoint.   
        /// </summary>
        /// <value>The requested stream name. Stream names are unique per device endpoint.   </value>
        [DataMember(Name="StreamName", EmitDefaultValue=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorCloseStreamMessage {\n");
            sb.Append("  StreamName: ").Append(StreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConnectorCloseStreamMessage);
        }

        /// <summary>
        /// Returns true if ConnectorCloseStreamMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectorCloseStreamMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorCloseStreamMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StreamName == other.StreamName ||
                    this.StreamName != null &&
                    this.StreamName.Equals(other.StreamName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StreamName != null)
                    hash = hash * 59 + this.StreamName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}