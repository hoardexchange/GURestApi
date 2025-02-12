/* 
 * Golem unlimited low level hub API
 *
 * API description in Markdown.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = GURestApi.Client.OpenAPIDateConverter;

namespace GURestApi.Model
{
    /// <summary>
    /// General information about given HUB.
    /// </summary>
    [DataContract]
    public partial class HubInfo :  IEquatable<HubInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubInfo" /> class.
        /// </summary>
        /// <param name="version">semver of hub..</param>
        /// <param name="build">build.</param>
        /// <param name="caps">hub protocol capabilities.</param>
        public HubInfo(string version = default(string), BuildInfo build = default(BuildInfo), Dictionary<string, string> caps = default(Dictionary<string, string>))
        {
            this.Version = version;
            this.Build = build;
            this.Caps = caps;
        }
        
        /// <summary>
        /// node public key hash in ethereum format
        /// </summary>
        /// <value>node public key hash in ethereum format</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; private set; }

        /// <summary>
        /// semver of hub.
        /// </summary>
        /// <value>semver of hub.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public BuildInfo Build { get; set; }

        /// <summary>
        /// hub protocol capabilities
        /// </summary>
        /// <value>hub protocol capabilities</value>
        [DataMember(Name="caps", EmitDefaultValue=false)]
        public Dictionary<string,string> Caps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HubInf{\n");
            sb.Append("\tNodeId: ").Append(NodeId).Append("\n");
            sb.Append("\tVersion: ").Append(Version).Append("\n");
            sb.Append("\tBuild: ").Append(Build).Append("\n");
            sb.Append("\tCaps: ").Append(Caps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HubInfo);
        }

        /// <summary>
        /// Returns true if HubInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HubInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Caps == input.Caps ||
                    this.Caps != null &&
                    this.Caps.SequenceEqual(input.Caps)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Caps != null)
                    hashCode = hashCode * 59 + this.Caps.GetHashCode();
                return hashCode;
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
