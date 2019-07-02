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
    /// synchronous exec of session entry point
    /// </summary>
    [DataContract]
    public partial class ExecCommand :  Command, IEquatable<ExecCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecCommand" /> class.
        /// </summary>
        /// <param name="executable">executable.</param>
        /// <param name="args">args.</param>
        public ExecCommand(string executable = default(string), List<string> args = default(List<string>))
            :base(CommandType.ExecCommand)
        {
            this.Executable = executable;
            this.Args = args;
        }
        
        /// <summary>
        /// Gets or Sets Executable
        /// </summary>
        [DataMember(Name="executable", EmitDefaultValue=false)]
        public string Executable { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecCommand {\n");
            sb.Append("  Executable: ").Append(Executable).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ExecCommand);
        }

        /// <summary>
        /// Returns true if ExecCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Executable == input.Executable ||
                    (this.Executable != null &&
                    this.Executable.Equals(input.Executable))
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Executable != null)
                    hashCode = hashCode * 59 + this.Executable.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
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
