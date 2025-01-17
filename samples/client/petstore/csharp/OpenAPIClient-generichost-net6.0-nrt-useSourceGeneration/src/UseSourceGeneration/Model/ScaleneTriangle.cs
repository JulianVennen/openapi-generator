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
    /// ScaleneTriangle
    /// </summary>
    public partial class ScaleneTriangle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleneTriangle" /> class.
        /// </summary>
        /// <param name="shapeType">shapeType</param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public ScaleneTriangle(string shapeType, string triangleType)
        {
            ShapeType = shapeType;
            TriangleType = triangleType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }

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
            sb.Append("class ScaleneTriangle {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
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
    /// A Json converter for type <see cref="ScaleneTriangle" />
    /// </summary>
    public class ScaleneTriangleJsonConverter : JsonConverter<ScaleneTriangle>
    {
        /// <summary>
        /// Deserializes json to <see cref="ScaleneTriangle" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ScaleneTriangle Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? shapeType = default;
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
                        case "shapeType":
                            shapeType = utf8JsonReader.GetString();
                            break;
                        case "triangleType":
                            triangleType = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (shapeType == null)
                throw new ArgumentNullException(nameof(shapeType), "Property is required for class ScaleneTriangle.");

            if (triangleType == null)
                throw new ArgumentNullException(nameof(triangleType), "Property is required for class ScaleneTriangle.");

            return new ScaleneTriangle(shapeType, triangleType);
        }

        /// <summary>
        /// Serializes a <see cref="ScaleneTriangle" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scaleneTriangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ScaleneTriangle scaleneTriangle, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, scaleneTriangle, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ScaleneTriangle" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="scaleneTriangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ScaleneTriangle scaleneTriangle, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("shapeType", scaleneTriangle.ShapeType);
            writer.WriteString("triangleType", scaleneTriangle.TriangleType);
        }
    }

    /// <summary>
    /// The ScaleneTriangleSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ScaleneTriangle))]
    public partial class ScaleneTriangleSerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The ScaleneTriangleSerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public ScaleneTriangleSerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// ScaleneTriangleDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(ScaleneTriangle))]
    public partial class ScaleneTriangleDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// ScaleneTriangleDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public ScaleneTriangleDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
