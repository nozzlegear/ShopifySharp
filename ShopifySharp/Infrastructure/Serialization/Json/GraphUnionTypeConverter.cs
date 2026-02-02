#nullable enable
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A JSON converter for GraphQL union base types that handles polymorphic deserialization
/// by directly deserializing to concrete types that inherit from the union base.
/// </summary>
/// <typeparam name="TUnion">The union base type (e.g., CustomerPaymentInstrument)</typeparam>
internal class GraphUnionTypeConverter<TUnion> : JsonConverter<TUnion>
    where TUnion : class
{
    private static IJsonSerializer ResolveSerializer(JsonSerializerOptions options, IServiceProvider? serviceProvider = null)
    {
        return InternalServiceResolver.GetServiceOrDefault<IJsonSerializer>(serviceProvider, () => new SystemJsonSerializer(options));
    }

    public override TUnion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var rootElement = new SystemJsonElement(doc.RootElement, doc);

        // Get __typename to determine the correct concrete type
        if (!rootElement.TryGetProperty("__typename", out var typenameElement))
            return null;

        if (typenameElement.ValueType != JsonValueType.String)
            return null;

        var typename = ((JsonElement) typenameElement.GetRawObject()).GetString();
        if (string.IsNullOrEmpty(typename))
            return null;

        // Find the wrapper type for this union type and typename
        var wrapperTypeName = $"{typeToConvert.Name}{typename}";
        var wrapperType = typeToConvert.Assembly.GetTypes()
            .FirstOrDefault(t => t.Name == wrapperTypeName && t.IsSubclassOf(typeToConvert));

        if (wrapperType == null)
            return null;

        // Get the Value property type (the concrete type we need to deserialize to)
        var valueProperty = wrapperType.GetProperty("Value");
        if (valueProperty == null)
            return null;

        var concreteType = valueProperty.PropertyType;

        // Create a new options instance without this converter to avoid infinite recursion
        var newOptions = new JsonSerializerOptions(options);
        var convertersToRemove = newOptions.Converters
            .Where(c => c.GetType().IsGenericType &&
                c.GetType().GetGenericTypeDefinition() == typeof(GraphUnionTypeConverter<>))
            .ToList();

        foreach (var converter in convertersToRemove)
            newOptions.Converters.Remove(converter);

        // Deserialize to the concrete type
        var serializer = ResolveSerializer(newOptions);
        var concreteObject = serializer.Deserialize(rootElement, concreteType);
        //JsonSerializer.Deserialize(rootElement.GetRawText(), concreteType, newOptions);
        if (concreteObject == null)
            return null;

        // Create the wrapper using its constructor
        var constructor = wrapperType.GetConstructor([concreteType]);
        if (constructor == null)
            return null;

        return (TUnion)constructor.Invoke([concreteObject]);
    }

    public override void Write(Utf8JsonWriter jsonWriter, TUnion? value, JsonSerializerOptions options)
    {
        var writer = new SystemJsonWriter(jsonWriter);

        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        // Get the Value property from the wrapper and serialize it
        var valueProperty = value.GetType().GetProperty("Value");
        if (valueProperty != null)
        {
            var wrappedValue = valueProperty.GetValue(value);
            if (wrappedValue != null)
            {
                // Create a new options instance without this converter to avoid infinite recursion
                var newOptions = new JsonSerializerOptions(options);
                var convertersToRemove = newOptions.Converters
                    .Where(c => c.GetType().IsGenericType &&
                        c.GetType().GetGenericTypeDefinition() == typeof(GraphUnionTypeConverter<>))
                    .ToList();

                foreach (var converter in convertersToRemove)
                    newOptions.Converters.Remove(converter);

                // Serialize the wrapped value using the new options
                var serializer = ResolveSerializer(newOptions);
                serializer.Serialize(writer, wrappedValue, wrappedValue.GetType());
                return;
            }
        }

        // If Value is null or doesn't exist, write null
        writer.WriteNullValue();
    }
}
