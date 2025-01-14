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
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace GURestApi.Model
{
    internal class CommandConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            /*JToken jObject = JToken.ReadFrom(reader);
            BCClientType type = jObject["Type"].ToObject<BCClientType>();

            BCClientConfig result;
            switch (type)
            {
                case BCClientType.Ethereum:
                    result = new EthereumClientConfig();
                    break;
                case BCClientType.Plasma:
                    result = new PlasmaClientConfig();
                    break;
                default:
                    throw new NotSupportedException();
            }

            serializer.Populate(jObject.CreateReader(), result);

            return result;*/
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Command cmd = value as Command;
            JsonObjectContract contract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(value.GetType());

            writer.WriteStartObject();
            Func<CommandType, string> enumName = (enumeration) =>
            {
                MemberInfo[] memberInfo = enumeration.GetType().GetMember(enumeration.ToString());

                if (memberInfo != null && memberInfo.Length > 0)
                {

                    object[] attributes = memberInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);

                    if (attributes != null && attributes.Length > 0)
                    {
                        return ((EnumMemberAttribute)attributes[0]).Value;
                    }

                }

                return enumeration.ToString();
            };
            writer.WritePropertyName(enumName(cmd.Type));
            writer.WriteStartObject();
            foreach (var property in contract.Properties)
            {
                if (!property.Ignored)
                {
                    writer.WritePropertyName(property.PropertyName);
                    serializer.Serialize(writer, property.ValueProvider.GetValue(value));
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsSubclassOf(typeof(Command)))
                return true;
            return false;
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommandType
    {
        [EnumMember(Value = "exec")]
        ExecCommand = 1,
        [EnumMember(Value = "open")]
        OpenCommand,
        [EnumMember(Value = "close")]
        CloseCommand,
        [EnumMember(Value = "start")]
        StartCommand,
        [EnumMember(Value = "stop")]
        StopCommand,
        [EnumMember(Value = "add_tags")]
        AddTagsCommand,
        [EnumMember(Value = "del_tags")]
        DelTagsCommand,
        [EnumMember(Value = "downloadFile")]
        DownloadFileCommand,
        [EnumMember(Value = "uploadFile")]
        UploadFileCommand,
    }

    /// <summary>
    /// Command
    /// </summary>
    [JsonConverter(typeof(CommandConverter))]
    [DataContract]
    public abstract class Command : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Command" /> class.
        /// </summary>
        protected Command(CommandType type)
        {
            Type = type;
        }

        public CommandType Type {get; private set;}

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Command {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
