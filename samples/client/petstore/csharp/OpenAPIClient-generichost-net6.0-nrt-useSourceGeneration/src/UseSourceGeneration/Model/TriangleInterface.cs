// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// TriangleInterface
    /// </summary>
    public partial class TriangleInterface : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleInterface" /> class.
        /// </summary>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public TriangleInterface(string triangleType)
        {
            TriangleType = triangleType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [JsonPropertyName("triangleType")]
        public string TriangleType { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TriangleInterface {\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="TriangleInterface" />
    /// </summary>
    public class TriangleInterfaceJsonConverter : JsonConverter<TriangleInterface>
    {
        /// <summary>
        /// Deserializes json to <see cref="TriangleInterface" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TriangleInterface Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? triangleType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "triangleType":
                            triangleType = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (triangleType == null)
                throw new ArgumentNullException(nameof(triangleType), "Property is required for class TriangleInterface.");

            return new TriangleInterface(triangleType);
        }

        /// <summary>
        /// Serializes a <see cref="TriangleInterface" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="triangleInterface"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TriangleInterface triangleInterface, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, triangleInterface, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TriangleInterface" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="triangleInterface"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TriangleInterface triangleInterface, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("triangleType", triangleInterface.TriangleType);
        }
    }

    /// <summary>
    /// The TriangleInterfaceSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(TriangleInterface))]
    public partial class TriangleInterfaceSerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The TriangleInterfaceSerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public TriangleInterfaceSerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// TriangleInterfaceDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(TriangleInterface))]
    public partial class TriangleInterfaceDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// TriangleInterfaceDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public TriangleInterfaceDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
