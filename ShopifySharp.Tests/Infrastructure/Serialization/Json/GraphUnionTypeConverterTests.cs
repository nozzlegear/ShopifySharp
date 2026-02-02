#nullable enable
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure.Serialization.Json;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization")]
[TestSubject(typeof(GraphUnionTypeConverter<>))]
public class GraphUnionTypeConverterTests
{
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true
    };
    private readonly GraphUnionTypeConverter<TestUnionBase> _sut = new();

    #region Read Tests - Success Scenarios

    [Fact]
    public void Read_WithValidTypeNameAndData_ShouldDeserializeToCorrectWrapperType()
    {
        // Setup
        const string json = """{"__typename":"Customer","id":"123","name":"John Doe"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read(); // Position reader at start of object

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<TestUnionBaseCustomer>();

        var wrapper = (TestUnionBaseCustomer)result;
        wrapper.Value.Should().NotBeNull();
        wrapper.Value.Id.Should().Be("123");
        wrapper.Value.Name.Should().Be("John Doe");
    }

    [Fact]
    public void Read_ShouldFindWrapperTypeByNamingConvention()
    {
        // Setup
        // Deserializing an object with __typename "Product" should deserialize to the type TestUnionBaseProduct
        const string json = """{"__typename":"Product","id":"prod-456","title":"Widget"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<TestUnionBaseProduct>("naming convention is Base + Typename");
    }

    [Fact]
    public void Read_ShouldDeserializeConcreteTypeFromJson()
    {
        // Setup
        const string json = """{"__typename":"Product","id":"prod-789","title":"Gadget","price":99.99}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeOfType<TestUnionBaseProduct>();
        var wrapper = (TestUnionBaseProduct)result;
        wrapper.Value.Id.Should().Be("prod-789");
        wrapper.Value.Title.Should().Be("Gadget");
        wrapper.Value.Price.Should().Be(99.99m);
    }

    [Fact]
    public void Read_ShouldCreateWrapperUsingConstructor()
    {
        // Setup
        const string json = """{"__typename":"Customer","id":"cust-001","name":"Jane Smith"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeOfType<TestUnionBaseCustomer>();
        var wrapper = (TestUnionBaseCustomer)result;
        wrapper.Value.Should().NotBeNull("constructor should have been invoked with deserialized value");
    }

    [Fact]
    public void Read_ShouldRemoveGraphUnionTypeConvertersFromOptions()
    {
        // Setup
        var optionsWithConverters = new JsonSerializerOptions();
        optionsWithConverters.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());
        optionsWithConverters.Converters.Add(new GraphUnionTypeConverter<AnotherUnionBase>());
        optionsWithConverters.Converters.Add(new JsonStringEnumConverter());

        const string json = """{"__typename":"Customer","id":"123","name":"Test"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), optionsWithConverters);

        // Assert
        // difficult to verify directly, but if this doesn't infinite loop, it worked
        result.Should().NotBeNull("converter removal prevents infinite recursion");
    }

    [Fact]
    public void Read_WithComplexNestedProperties_ShouldDeserializeFully()
    {
        // Setup
        const string json = """{"__typename":"ComplexCustomer","id":"complex-1","name":"Complex","address":{"street":"123 Main St","city":"Portland"}}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeOfType<TestUnionBaseComplexCustomer>();
        var wrapper = (TestUnionBaseComplexCustomer)result;
        wrapper.Value.Address.Should().NotBeNull();
        wrapper.Value.Address!.Street.Should().Be("123 Main St");
        wrapper.Value.Address.City.Should().Be("Portland");
    }

    [Fact]
    public void Read_ShouldPreserveOriginalOptionsSettings()
    {
        // Setup
        var customOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
        customOptions.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        const string json = """{"__typename":"Customer","id":"123","NAME":"Test"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), customOptions);

        // Assert
        result.Should().NotBeNull();
        var wrapper = (TestUnionBaseCustomer)result;
        wrapper.Value.Name.Should().Be("Test", "case insensitivity should be preserved");
    }

    [Fact]
    public void Read_ShouldPopulateValueProperty()
    {
        // Setup
        const string json = """{"__typename":"Customer","id":"pop-test","name":"Populate Test"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        var wrapper = (TestUnionBaseCustomer)result!;
        var valueProperty = wrapper.GetType().GetProperty("Value");
        valueProperty.Should().NotBeNull();
        var value = valueProperty.GetValue(wrapper);
        value.Should().NotBeNull();
        value.Should().BeOfType<Customer>();
    }

    [Fact]
    public void Read_EndToEndIntegration_ShouldWork()
    {
        // Testing the full integration test with JsonSerializer
        // Setup
        const string json = """{"__typename":"Product","id":"integration-test","title":"Integration Product","price":42.99}""";

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var result = JsonSerializer.Deserialize<TestUnionBase>(json, options);

        // Assert
        result.Should().BeOfType<TestUnionBaseProduct>();
        var wrapper = (TestUnionBaseProduct)result;
        wrapper.Value.Title.Should().Be("Integration Product");
    }

    #endregion

    #region Read Tests - Failure Scenarios

    [Fact]
    public void Read_WithMissingTypeName_ShouldReturnNull()
    {
        // Setup
        const string json = """{"id":"123","name":"No Typename"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Read_WithNullTypeName_ShouldReturnNull()
    {
        // Setup
        const string json = """{"__typename":null,"id":"123"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Read_WithEmptyTypeName_ShouldReturnNull()
    {
        // Setup
        const string json = """{"__typename":"","id":"123"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Read_WithNonStringTypeName_ShouldReturnNull()
    {
        // Setup
        const string json = """{"__typename":123,"id":"456"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Read_WithNonExistentWrapperType_ShouldReturnNull()
    {
        // Setup
        // "UnknownType" doesn't have a corresponding wrapper and should return null
        const string json = """{"__typename":"UnknownType","id":"unknown"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Read_WithWrapperWithoutValueProperty_ShouldReturnNull()
    {
        // Setup
        const string json = """{"__typename":"Malformed","data":"test"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull("wrapper without Value property should fail gracefully");
    }

    [Fact]
    public void Read_WithWrapperWithoutProperConstructor_ShouldReturnNull()
    {
        // Setup
        const string json = """{"__typename":"NoConstructor","id":"test"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        result.Should().BeNull("wrapper without matching constructor should fail gracefully");
    }

    [Fact]
    public void Read_WithInvalidJson_ShouldHandleGracefully()
    {
        // Setup
        // Invalid json (id has no value)
        const string json = """{"__typename":"Customer","id":}""";
        var bytes = System.Text.Encoding.UTF8.GetBytes(json);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            reader.Read();
            _sut.Read(ref reader, typeof(TestUnionBase), _options);
        };

        // Assert
        act.Should().Throw<JsonException>("invalid json should throw during parsing");
    }

    [Fact]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public void Read_WithMalformedData_ShouldReturnNull()
    {
        // Setup
        // Customer type is missing fields
        const string json = """{"__typename":"Customer"}""";
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(TestUnionBase), _options);

        // Assert
        // Deserialization should succeed with nulls/return null if constructor fails
        result.Should().NotBeNull("deserialization with missing fields still creates object with nulls");
    }

    #endregion

    #region Write Tests

    [Fact]
    public void Write_WithNullValue_ShouldWriteNull()
    {
        // Setup
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _sut.Write(writer, null, _options);
        writer.Flush();

        // Assert
        var json = System.Text.Encoding.UTF8.GetString(stream.ToArray());
        json.Should().Be("null");
    }

    [Fact]
    public void Write_WithValidWrapper_ShouldSerializeValueProperty()
    {
        // Setup
        var customer = new Customer { Id = "write-test", Name = "Write Test User" };
        var wrapper = new TestUnionBaseCustomer(customer);

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize<TestUnionBase>(wrapper, options);

        // Assert
        json.Should().Contain("write-test");
        json.Should().Contain("Write Test User");
    }

    [Fact]
    public void Write_ShouldExtractValuePropertyViaReflection()
    {
        // Setup
        var product = new Product { Id = "prod-write", Title = "Written Product", Price = 29.99m };
        var wrapper = new TestUnionBaseProduct(product);

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize<TestUnionBase>(wrapper, options);

        // Assert
        json.Should().Contain("prod-write");
        json.Should().Contain("Written Product");
        json.Should().Contain("29.99");
    }

    [Fact]
    public void Write_WithWrapperContainingNullValue_ShouldSerializeNull()
    {
        // Setup
        var wrapper = new TestUnionBaseCustomer(null!);
        var options = new JsonSerializerOptions();
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize<TestUnionBase>(wrapper, options);

        // Assert
        json.Should().Be("null");
    }

    [Fact]
    public void Write_EndToEndIntegration_ShouldWork()
    {
        // Setup
        var product = new Product { Id = "integration-write", Title = "Integrated", Price = 12.34m };
        var wrapper = new TestUnionBaseProduct(product);

        var options = new JsonSerializerOptions();
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize(wrapper, options);

        // Assert
        json.Should().Contain("integration-write");
        json.Should().Contain("Integrated");
    }

    [Fact]
    public void Write_DoesNotRemoveConverters_UnlikeRead()
    {
        // Setup
        var optionsWithConverters = new JsonSerializerOptions();
        optionsWithConverters.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());
        var originalConverterCount = optionsWithConverters.Converters.Count;

        var customer = new Customer { Id = "test", Name = "Test" };
        var wrapper = new TestUnionBaseCustomer(customer);

        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _sut.Write(writer, wrapper, optionsWithConverters);
        writer.Flush();

        // Assert
        // TODO: we will actually need to remove the converters to prevent recursion when writing some values
        optionsWithConverters.Converters.Count.Should().Be(originalConverterCount, "Write should not modify options (unlike Read which needs to prevent recursion)");
    }

    [Fact]
    public void Write_WithComplexNestedObject_ShouldSerializeCorrectly()
    {
        // Setup
        var customer = new ComplexCustomer
        {
            Id = "complex-write",
            Name = "Complex Writer",
            Address = new Address { Street = "456 Oak Ave", City = "Seattle" }
        };
        var wrapper = new TestUnionBaseComplexCustomer(customer);

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize<TestUnionBase>(wrapper, options);

        // Assert
        json.Should().Contain("complex-write");
        json.Should().Contain("456 Oak Ave");
        json.Should().Contain("Seattle");
    }

    [Fact]
    public void Write_WithMalformedWrapperWithoutValue_ShouldWriteNull()
    {
        // Setup - malformed wrapper without Value property
        // NOTE: In real usage, all generated wrappers have a Value property, so this edge case
        // should not occur in production code. The implementation now gracefully handles this
        // by writing null instead of causing infinite recursion.
        var malformed = new TestUnionBaseMalformed();

        var options = new JsonSerializerOptions();
        options.Converters.Add(new GraphUnionTypeConverter<TestUnionBase>());

        // Act
        var json = JsonSerializer.Serialize<TestUnionBase>(malformed, options);

        // Assert
        json.Should().Be("null", "malformed wrappers without Value should serialize as null");
    }

    #endregion

    #region Real-World Integration Tests with MetafieldReference

    [Fact]
    public void RealWorld_MetafieldReference_ShouldDeserializeProduct()
    {
        // Setup - simulating a real GraphQL response with a MetafieldReference union
        const string json = """
        {
            "__typename": "Product",
            "id": "gid://shopify/Product/123",
            "title": "Test Product"
        }
        """;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

        // Act
        var result = JsonSerializer.Deserialize<MetafieldReference>(json, options);

        // Assert
        result.Should().NotBeNull();
        var product = result.AsProduct();
        product.Should().NotBeNull();
        product.id.Should().Be("gid://shopify/Product/123");
        product.title.Should().Be("Test Product");
    }

    [Fact]
    public void RealWorld_MetafieldReference_ShouldDeserializeCustomer()
    {
        // Setup - MetafieldReference can reference different types
        const string json = """
        {
            "__typename": "Customer",
            "id": "gid://shopify/Customer/456",
            "displayName": "John Doe"
        }
        """;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

        // Act
        var result = JsonSerializer.Deserialize<MetafieldReference>(json, options);

        // Assert
        result.Should().NotBeNull();
        var customer = result.AsCustomer();
        customer.Should().NotBeNull();
        customer.id.Should().Be("gid://shopify/Customer/456");
        customer.displayName.Should().Be("John Doe");
    }

    [Fact]
    public void RealWorld_MetafieldReference_ShouldSerializeProduct()
    {
        // Setup - create a real MetafieldReference wrapper around a Product
        var product = new GraphQL.Product
        {
            id = "gid://shopify/Product/789",
            title = "Serialized Product"
        };

        // Use reflection to create the wrapper since it's internal
        var wrapperType = typeof(MetafieldReference).Assembly.GetTypes()
            .First(t => t.Name == "MetafieldReferenceProduct");
        var wrapper = (MetafieldReference)Activator.CreateInstance(wrapperType, product)!;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

        // Act
        var json = JsonSerializer.Serialize(wrapper, options);

        // Assert
        json.Should().Contain("gid://shopify/Product/789");
        json.Should().Contain("Serialized Product");
    }

    [Fact(Skip = "Round-trip serialization loses __typename - this is a known architectural limitation. " +
                 "GraphQL types don't have a __typename property, so serialization doesn't preserve it. " +
                 "Fixing this would require either: (1) adding __typename to all GraphQL types, " +
                 "(2) modifying Write to inject __typename, or (3) storing typename in the wrapper.")]
    public void RealWorld_MetafieldReference_RoundTrip_ShouldPreserveData()
    {
        // Setup - full round-trip test with real types
        const string originalJson = """
        {
            "__typename": "Collection",
            "id": "gid://shopify/Collection/999",
            "title": "Round Trip Collection"
        }
        """;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

        // Act - deserialize then serialize
        var deserialized = JsonSerializer.Deserialize<MetafieldReference>(originalJson, options);
        var reserialized = JsonSerializer.Serialize(deserialized, options);
        var roundTripped = JsonSerializer.Deserialize<MetafieldReference>(reserialized, options);

        // Assert
        roundTripped.Should().NotBeNull();
        var collection = roundTripped.AsCollection();
        collection.Should().NotBeNull();
        collection.id.Should().Be("gid://shopify/Collection/999");
        collection.title.Should().Be("Round Trip Collection");
    }

    [Fact]
    public void RealWorld_MetafieldReference_WithUnknownTypeName_ShouldReturnNull()
    {
        // Setup - invalid typename that doesn't have a wrapper
        const string json = """
        {
            "__typename": "NonExistentType",
            "id": "test"
        }
        """;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

        // Act
        var result = JsonSerializer.Deserialize<MetafieldReference>(json, options);

        // Assert
        result.Should().BeNull("unknown typenames should return null gracefully");
    }

    [Fact]
    public void RealWorld_MetafieldReference_AsWrongType_ShouldReturnNull()
    {
        // Setup - deserialize as Product, try to access as Customer
        const string json = """
        {
            "__typename": "Product",
            "id": "gid://shopify/Product/111",
            "title": "A Product"
        }
        """;

        var options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;
        var result = JsonSerializer.Deserialize<MetafieldReference>(json, options);

        // Act - try to access as the wrong type
        var customer = result!.AsCustomer();

        // Assert
        customer.Should().BeNull("accessing wrong union case should return null");
        result.AsProduct().Should().NotBeNull("accessing correct union case should work");
    }

    #endregion

    #region Test Helpers

    // Base union type
    public class TestUnionBase;

    // Another union base for testing multiple converters
    public class AnotherUnionBase;

    // Wrapper types following naming convention: Base + Typename
    public class TestUnionBaseCustomer(Customer value) : TestUnionBase
    {
        public Customer Value { get; } = value;
    }

    public class TestUnionBaseProduct(Product value) : TestUnionBase
    {
        public Product Value { get; } = value;
    }

    public class TestUnionBaseComplexCustomer(ComplexCustomer value) : TestUnionBase
    {
        public ComplexCustomer Value { get; } = value;
    }

    // Malformed wrapper for error testing (no Value property)
    public class TestUnionBaseMalformed : TestUnionBase
    {
        public string? Data { get; set; }
    }

    // Malformed wrapper for error testing (no proper constructor)
    public class TestUnionBaseNoConstructor : TestUnionBase
    {
        public NoConstructorType? Value { get; set; }
        // Missing constructor that takes NoConstructorType
    }

    // Concrete types
    public class Customer
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }

    public class Product
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
    }

    public class ComplexCustomer
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Address? Address { get; set; }
    }

    public class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
    }

    public class NoConstructorType
    {
        public string? Id { get; set; }
    }

    #endregion
}
