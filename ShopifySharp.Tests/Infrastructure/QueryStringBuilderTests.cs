#nullable enable
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "Infrastructure")]
[TestSubject(typeof(QueryStringBuilder))]
public class QueryStringBuilderTests
{
    private readonly QueryStringBuilder _sut = new();

    #region Build Tests

    [Fact]
    public void Build_WithEmptyQuery_ShouldReturnOnlyName()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("testQuery");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("testQuery");
    }

    [Fact]
    public void Build_WithAlias_ShouldPrependAliasWithColon()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("testQuery");
        A.CallTo(() => query.AliasName).Returns("myAlias");
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("myAlias:testQuery");
    }

    [Fact]
    public void Build_WithArguments_ShouldIncludeParenthesesAndParams()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("testQuery");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns(new Dictionary<string, object?> { ["id"] = "123" });
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("testQuery(id:\"123\")");
    }

    [Fact]
    public void Build_WithFields_ShouldIncludeBracesAndFieldNames()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("testQuery");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns(["id", "name"]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("testQuery{id name}");
    }

    [Fact]
    public void Build_WithAliasArgumentsAndFields_ShouldBuildCompleteQuery()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("product");
        A.CallTo(() => query.AliasName).Returns("myProduct");
        A.CallTo(() => query.Arguments).Returns(new Dictionary<string, object?> { ["id"] = "gid://123" });
        A.CallTo(() => query.SelectList).Returns(["id", "title"]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("myProduct:product(id:\"gid://123\"){id title}");
    }

    [Fact]
    public void Build_WithNestedQuery_ShouldBuildRecursively()
    {
        // Setup
        var nestedQuery = A.Fake<IQuery<TestNestedObject>>();
        A.CallTo(() => nestedQuery.QueryName).Returns("nested");
        A.CallTo(() => nestedQuery.AliasName).Returns(string.Empty);
        A.CallTo(() => nestedQuery.Arguments).Returns([]);
        A.CallTo(() => nestedQuery.SelectList).Returns(["nestedId"]);
        A.CallTo(() => nestedQuery.Build()).Returns("nested{nestedId}");

        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("parent");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns(["id", nestedQuery]);

        // Act
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("parent{id nested{nestedId}}");
    }

    [Fact]
    public void Build_CalledMultipleTimesWithoutClear_ShouldAppend()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("test");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        _sut.Build(query);
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("testtest", "without Clear(), subsequent Build() calls should append");
    }

    [Fact]
    public void Build_AfterClear_ShouldStartFresh()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("test");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        _sut.Build(query);
        _sut.Clear();
        var result = _sut.Build(query);

        // Assert
        result.Should().Be("test", "after Clear(), the next Build() should start fresh");
    }

    #endregion

    #region FormatQueryParam Tests - Primitives

    [Fact]
    public void FormatQueryParam_WithNull_ShouldReturnNull()
    {
        // Act
        var result = _sut.FormatQueryParam(null);

        // Assert
        result.Should().Be("null");
    }

    [Fact]
    public void FormatQueryParam_WithString_ShouldReturnQuotedString()
    {
        // Act
        var result = _sut.FormatQueryParam("hello");

        // Assert
        result.Should().Be("\"hello\"");
    }

    [Fact]
    public void FormatQueryParam_WithStringContainingQuotes_ShouldEscapeQuotes()
    {
        // Act
        var result = _sut.FormatQueryParam("say \"hello\"");

        // Assert
        result.Should().Be("\"say \\\"hello\\\"\"");
    }

    [Fact]
    public void FormatQueryParam_WithChar_ShouldReturnQuotedChar()
    {
        // Act
        var result = _sut.FormatQueryParam('a');

        // Assert
        result.Should().Be("\"a\"");
    }

    [Theory]
    [InlineData(42, "42")]
    [InlineData(-999, "-999")]
    [InlineData(0, "0")]
    public void FormatQueryParam_WithInt_ShouldReturnUnquotedNumber(int value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData((byte)255, "255")]
    [InlineData((byte)0, "0")]
    public void FormatQueryParam_WithByte_ShouldReturnUnquotedNumber(byte value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData((sbyte)127, "127")]
    [InlineData((sbyte)-128, "-128")]
    public void FormatQueryParam_WithSByte_ShouldReturnUnquotedNumber(sbyte value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData((short)32767, "32767")]
    [InlineData((short)-32768, "-32768")]
    public void FormatQueryParam_WithShort_ShouldReturnUnquotedNumber(short value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData((ushort)65535, "65535")]
    [InlineData((ushort)0, "0")]
    public void FormatQueryParam_WithUShort_ShouldReturnUnquotedNumber(ushort value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(4294967295, "4294967295")]
    [InlineData((uint)0, "0")]
    public void FormatQueryParam_WithUInt_ShouldReturnUnquotedNumber(uint value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void FormatQueryParam_WithLong_ShouldReturnUnquotedNumber()
    {
        // Act
        var result = _sut.FormatQueryParam(9223372036854775807L);

        // Assert
        result.Should().Be("9223372036854775807");
    }

    [Fact]
    public void FormatQueryParam_WithULong_ShouldReturnUnquotedNumber()
    {
        // Act
        var result = _sut.FormatQueryParam(18446744073709551615UL);

        // Assert
        result.Should().Be("18446744073709551615");
    }

    [Theory]
    [InlineData(3.14f, "3.14")]
    [InlineData(-2.5f, "-2.5")]
    [InlineData(0.0f, "0")]
    public void FormatQueryParam_WithFloat_ShouldUseUsCulture(float value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected, "floats should use period separator, not comma");
    }

    [Theory]
    [InlineData(3.14159, "3.14159")]
    [InlineData(-2.5, "-2.5")]
    [InlineData(0.0, "0")]
    public void FormatQueryParam_WithDouble_ShouldUseUsCulture(double value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected, "doubles should use period separator, not comma");
    }

    [Fact]
    public void FormatQueryParam_WithDecimal_ShouldUseUsCulture()
    {
        // Act
        var result = _sut.FormatQueryParam(123.45m);

        // Assert
        result.Should().Be("123.45", "decimals should use period separator, not comma");
    }

    [Theory]
    [InlineData(true, "true")]
    [InlineData(false, "false")]
    public void FormatQueryParam_WithBoolean_ShouldReturnLowercase(bool value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected, "GraphQL booleans are lowercase");
    }

    [Fact]
    public void FormatQueryParam_WithEnum_ShouldReturnEnumValueAsStringWithoutQuotes()
    {
        // Act
        var result = _sut.FormatQueryParam(TestEnum.ValueTwo);

        // Assert
        result.Should().Be("ValueTwo", "enums should serialize to their value without quotes");
    }

    [Fact]
    public void FormatQueryParam_WithDateTime_ShouldConvertToIso8601String()
    {
        // Setup
        var dateTime = new DateTime(2024, 6, 15, 13, 45, 30, DateTimeKind.Utc);

        // Act
        var result = _sut.FormatQueryParam(dateTime);

        // Assert
        result.Should().Be("\"2024-06-15T13:45:30.0000000Z\"", "DateTime should be ISO 8601 format and quoted");
    }

    #endregion

    #region FormatQueryParam Tests - Collections

    [Fact]
    public void FormatQueryParam_WithEmptyList_ShouldReturnEmptyArray()
    {
        // Setup
        var emptyList = new List<string>();

        // Act
        var result = _sut.FormatQueryParam(emptyList);

        // Assert
        result.Should().Be("[]");
    }

    [Fact]
    public void FormatQueryParam_WithStringList_ShouldReturnArrayOfQuotedStrings()
    {
        // Setup
        var list = new List<string> { "a", "b", "c" };

        // Act
        var result = _sut.FormatQueryParam(list);

        // Assert
        result.Should().Be("[\"a\",\"b\",\"c\"]");
    }

    [Fact]
    public void FormatQueryParam_WithIntegerList_ShouldReturnArrayOfNumbers()
    {
        // Setup
        var list = new List<int> { 1, 2, 3 };

        // Act
        var result = _sut.FormatQueryParam(list);

        // Assert
        result.Should().Be("[1,2,3]");
    }

    [Fact]
    public void FormatQueryParam_WithMixedList_ShouldHandleEachTypeCorrectly()
    {
        // Setup
        var list = new List<object?> { 1, "hello", true, null };

        // Act
        var result = _sut.FormatQueryParam(list);

        // Assert
        result.Should().Be("[1,\"hello\",true,null]");
    }

    [Fact]
    public void FormatQueryParam_WithNestedList_ShouldHandleRecursively()
    {
        // Setup
        var nestedList = new List<object>
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 }
        };

        // Act
        var result = _sut.FormatQueryParam(nestedList);

        // Assert
        result.Should().Be("[[1,2],[3,4]]");
    }

    [Fact]
    public void FormatQueryParam_WithEmptyDictionary_ShouldReturnEmptyObject()
    {
        // Setup
        var emptyDict = new Dictionary<string, object>();

        // Act
        var result = _sut.FormatQueryParam(emptyDict);

        // Assert
        result.Should().Be("{}");
    }

    [Fact]
    public void FormatQueryParam_WithSimpleDictionary_ShouldReturnObject()
    {
        // Setup
        var dict = new Dictionary<string, object>
        {
            ["foo"] = "bar",
            ["num"] = 42
        };

        // Act
        var result = _sut.FormatQueryParam(dict);

        // Assert
        result.Should().Be("{foo:\"bar\",num:42}");
    }

    [Fact]
    public void FormatQueryParam_WithNestedDictionary_ShouldHandleRecursively()
    {
        // Setup
        var dict = new Dictionary<string, object>
        {
            ["outer"] = new Dictionary<string, object>
            {
                ["inner"] = "value"
            }
        };

        // Act
        var result = _sut.FormatQueryParam(dict);

        // Assert
        result.Should().Be("{outer:{inner:\"value\"}}");
    }

    [Fact]
    public void FormatQueryParam_WithKeyValuePair_ShouldFormatAsKeyValue()
    {
        // Setup
        var kvp = new KeyValuePair<string, object>("key", "value");

        // Act
        var result = _sut.FormatQueryParam(kvp);

        // Assert
        result.Should().Be("key:\"value\"");
    }

    [Fact]
    public void FormatQueryParam_WithListOfKeyValuePairs_ShouldFormatAsArray()
    {
        // Setup
        var list = new List<KeyValuePair<string, object>>
        {
            new("a", 1),
            new("b", 2)
        };

        // Act
        var result = _sut.FormatQueryParam(list);

        // Assert
        result.Should().Be("[a:1,b:2]");
    }

    #endregion

    #region FormatQueryParam Tests - Complex Types

    [Fact]
    public void FormatQueryParam_WithAnonymousObject_ShouldConvertToDictionary()
    {
        // Setup
        var obj = new { foo = "bar", num = 42 };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Be("{foo:\"bar\",num:42}");
    }

    [Fact]
    public void FormatQueryParam_WithCustomObject_ShouldExtractProperties()
    {
        // Setup
        var obj = new TestObject
        {
            StringProp = "test",
            IntProp = 123,
            BoolProp = true
        };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("BoolProp:true");
        result.Should().Contain("IntProp:123");
        result.Should().Contain("StringProp:\"test\"");
    }

    [Fact]
    public void FormatQueryParam_WithObjectContainingNullProperties_ShouldExcludeNulls()
    {
        // Setup
        var obj = new TestObject
        {
            StringProp = "test",
            IntProp = null,
            BoolProp = null
        };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Be("{StringProp:\"test\"}");
    }

    [Fact]
    public void FormatQueryParam_WithCustomFormatter_ShouldUseFormatterForPropertyNames()
    {
        // Setup
        var formatter = new Func<PropertyInfo, string>(prop => prop.Name.ToLowerInvariant());
        var sut = new QueryStringBuilder(formatter);
        var obj = new TestObject { StringProp = "test" };

        // Act
        var result = sut.FormatQueryParam(obj);

        // Assert
        result.Should().Be("{stringprop:\"test\"}");
    }

    [Fact]
    public void FormatQueryParam_WithoutFormatter_ShouldUsePropertyNameAsIs()
    {
        // Setup
        var obj = new TestObject { StringProp = "test" };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Be("{StringProp:\"test\"}");
    }

    [Fact]
    public void FormatQueryParam_WithNestedObject_ShouldHandleRecursively()
    {
        // Setup
        var obj = new TestNestedObject
        {
            Outer = "outerValue",
            Inner = new TestObject { StringProp = "innerValue" }
        };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("Outer:\"outerValue\"");
        result.Should().Contain("Inner:{StringProp:\"innerValue\"}");
    }

    [Fact]
    public void FormatQueryParam_ObjectProperties_ShouldBeSortedAlphabetically()
    {
        // Setup
        var obj = new TestObject
        {
            StringProp = "z",
            IntProp = 1,
            BoolProp = true
        };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        // Properties should be in order: BoolProp, IntProp, StringProp
        var boolIndex = result.IndexOf("BoolProp", StringComparison.Ordinal);
        var intIndex = result.IndexOf("IntProp", StringComparison.Ordinal);
        var stringIndex = result.IndexOf("StringProp", StringComparison.Ordinal);

        boolIndex.Should().BeLessThan(intIndex);
        intIndex.Should().BeLessThan(stringIndex);
    }

    [Fact]
    public void FormatQueryParam_WithComplexNestedStructure_ShouldHandleCorrectly()
    {
        // Setup
        var obj = new
        {
            array = new[] { 1, 2, 3 },
            nested = new { inner = "value" },
            simple = "test"
        };

        // Act
        var result = _sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("array:[1,2,3]");
        result.Should().Contain("nested:{inner:\"value\"}");
        result.Should().Contain("simple:\"test\"");
    }

    #endregion

    #region FormatQueryParam Tests - Edge Cases

    [Fact]
    public void FormatQueryParam_WithVeryLargeNumbers_ShouldFormatCorrectly()
    {
        // Act
        var longResult = _sut.FormatQueryParam(long.MaxValue);
        var ulongResult = _sut.FormatQueryParam(ulong.MaxValue);

        // Assert
        longResult.Should().Be("9223372036854775807");
        ulongResult.Should().Be("18446744073709551615");
    }

    [Theory]
    [InlineData(-1, "-1")]
    [InlineData(-999999, "-999999")]
    [InlineData(-3.14, "-3.14")]
    public void FormatQueryParam_WithNegativeNumbers_ShouldIncludeMinusSign(object value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void FormatQueryParam_WithSpecialCharactersInString_ShouldHandle()
    {
        // Setup
        var specialString = "Line1\nLine2\tTabbed\r\nWindows";

        // Act
        var result = _sut.FormatQueryParam(specialString);

        // Assert
        result.Should().StartWith("\"");
        result.Should().EndWith("\"");
        result.Should().Contain("Line1");
        result.Should().Contain("Line2");
    }

    [Theory]
    [InlineData(0, "0")]
    [InlineData(0.0, "0")]
    [InlineData(0f, "0")]
    public void FormatQueryParam_WithZeroValues_ShouldFormatAsZero(object value, string expected)
    {
        // Act
        var result = _sut.FormatQueryParam(value);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void FormatQueryParam_InDifferentCulture_ShouldStillUseInvariantFormat()
    {
        // Setup
        var originalCulture = CultureInfo.CurrentCulture;
        try
        {
            // Set culture that uses comma as decimal separator
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");
            var decimalValue = 3.14;

            // Act
            var result = _sut.FormatQueryParam(decimalValue);

            // Assert
            result.Should().Be("3.14", "should use period separator regardless of culture");
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }
    }

    [Fact]
    public void FormatQueryParam_RecursionTest_DateTimeToString_ShouldNotCauseInfiniteLoop()
    {
        // Setup
        var dateTime = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc);

        // Act
        // This would cause infinite loop if DateTime recursion isn't handled correctly
        var act = () => _sut.FormatQueryParam(dateTime);

        // Assert
        act.Should().NotThrow("DateTime should convert to string and then format as string");

        var result = act();
        result.Should().StartWith("\"");
        result.Should().EndWith("\"");
    }

    #endregion

    #region AddParams Tests

    [Fact]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public void AddParams_WithNullQuery_ShouldThrowArgumentNullException()
    {
        // Act
        var act = () => _sut.AddParams<TestObject>(null!);

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName("query");
    }

    [Fact]
    public void AddParams_WithEmptyArguments_ShouldNotModifyQueryString()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.Arguments).Returns([]);

        // Act
        _sut.AddParams(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public void AddParams_WithSingleArgument_ShouldAddKeyValuePair()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.Arguments).Returns(new Dictionary<string, object?> { ["id"] = "123" });

        // Act
        _sut.AddParams(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Be("id:\"123\"");
    }

    [Fact]
    public void AddParams_WithMultipleArguments_ShouldSeparateWithCommas()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.Arguments).Returns(new Dictionary<string, object?>
        {
            ["first"] = 10,
            ["after"] = "cursor123",
            ["filter"] = new { status = "active" }
        });

        // Act
        _sut.AddParams(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Contain("first:10");
        result.Should().Contain("after:\"cursor123\"");
        result.Should().Contain("filter:");
        result.Should().NotEndWith(",", "trailing comma should be removed");
    }

    [Fact]
    public void AddParams_WithVariousValueTypes_ShouldFormatEachCorrectly()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.Arguments).Returns(new Dictionary<string, object?>
        {
            ["string"] = "test",
            ["int"] = 42,
            ["bool"] = true,
            ["null"] = null
        });

        // Act
        _sut.AddParams(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Contain("string:\"test\"");
        result.Should().Contain("int:42");
        result.Should().Contain("bool:true");
        result.Should().Contain("null:null");
    }

    #endregion

    #region AddFields Tests

    [Fact]
    public void AddFields_WithEmptySelectList_ShouldNotModifyQueryString()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns([]);

        // Act
        _sut.AddFields(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public void AddFields_WithSingleStringField_ShouldAppendFieldName()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { "id" });

        // Act
        _sut.AddFields(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Be("id");
    }

    [Fact]
    public void AddFields_WithMultipleStringFields_ShouldSeparateWithSpaces()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { "id", "name", "email" });

        // Act
        _sut.AddFields(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Be("id name email");
        result.Should().NotEndWith(" ", "trailing space should be removed");
    }

    [Fact]
    public void AddFields_WithIQueryField_ShouldCallBuild()
    {
        // Setup
        var subQuery = A.Fake<IQuery<TestNestedObject>>();
        A.CallTo(() => subQuery.Build()).Returns("nestedField{id}");

        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { subQuery });

        // Act
        _sut.AddFields(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Be("nestedField{id}");
        A.CallTo(() => subQuery.Build()).MustHaveHappenedOnceExactly();
    }

    [Fact]
    public void AddFields_WithMixedStringAndIQueryFields_ShouldHandleBoth()
    {
        // Setup
        var subQuery = A.Fake<IQuery<TestNestedObject>>();
        A.CallTo(() => subQuery.Build()).Returns("nested{value}");

        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { "id", subQuery, "name" });

        // Act
        _sut.AddFields(query);
        var result = _sut.QueryString.ToString();

        // Assert
        result.Should().Be("id nested{value} name");
    }

    [Fact]
    public void AddFields_WithInvalidFieldType_ShouldThrowArgumentException()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { "validField", 123 });

        // Act
        var act = () => _sut.AddFields(query);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("*Invalid Field Type*");
    }

    [Fact]
    public void AddFields_TrailingSpaceRemoval_ShouldWorkCorrectly()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.SelectList).Returns(new List<object?> { "field1", "field2", "field3" });

        // Act
        _sut.AddFields(query);

        // Assert
        _sut.QueryString.ToString().Should().NotEndWith(" ");
        _sut.QueryString.Length.Should().Be("field1 field2 field3".Length);
    }

    #endregion

    #region Clear Tests

    [Fact]
    public void Clear_ShouldEmptyQueryString()
    {
        // Setup
        _sut.QueryString.Append("some content");

        // Act
        _sut.Clear();

        // Assert
        _sut.QueryString.ToString().Should().BeEmpty();
        _sut.QueryString.Length.Should().Be(0);
    }

    [Fact]
    public void Clear_AfterBuild_ShouldAllowReuse()
    {
        // Setup
        var query = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query.QueryName).Returns("first");
        A.CallTo(() => query.AliasName).Returns(string.Empty);
        A.CallTo(() => query.Arguments).Returns([]);
        A.CallTo(() => query.SelectList).Returns([]);

        _sut.Build(query);

        var query2 = A.Fake<IQuery<TestObject>>();
        A.CallTo(() => query2.QueryName).Returns("second");
        A.CallTo(() => query2.AliasName).Returns(string.Empty);
        A.CallTo(() => query2.Arguments).Returns([]);
        A.CallTo(() => query2.SelectList).Returns([]);

        // Act
        _sut.Clear();
        var result = _sut.Build(query2);

        // Assert
        result.Should().Be("second", "after Clear(), new Build() should not contain previous content");
    }

    [Fact]
    public void Clear_CalledMultipleTimes_ShouldBeIdempotent()
    {
        // Setup
        _sut.QueryString.Append("content");

        // Act
        _sut.Clear();
        _sut.Clear();
        _sut.Clear();

        // Assert
        _sut.QueryString.ToString().Should().BeEmpty();
    }

    #endregion

    #region Custom Formatter Tests

    [Fact]
    public void Constructor_WithoutFormatter_ShouldAllowDefaultBehavior()
    {
        // Setup & Act
        var sut = new QueryStringBuilder();
        var obj = new TestObject { StringProp = "test" };
        var result = sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("StringProp:");
    }

    [Fact]
    public void Constructor_WithFormatter_ShouldStoreFormatter()
    {
        // Setup
        var formatter = new Func<PropertyInfo, string>(prop => $"custom_{prop.Name}");

        // Act
        var sut = new QueryStringBuilder(formatter);
        var obj = new TestObject { StringProp = "test" };
        var result = sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("custom_StringProp:");
    }

    [Fact]
    public void Formatter_ShouldOnlyAffectObjectToDictionary_NotPrimitives()
    {
        // Setup
        var formatter = new Func<PropertyInfo, string>(prop => prop.Name.ToUpperInvariant());
        var sut = new QueryStringBuilder(formatter);

        // Act
        var stringResult = sut.FormatQueryParam("test");
        var intResult = sut.FormatQueryParam(42);

        // Assert
        stringResult.Should().Be("\"test\"", "formatter shouldn't affect primitive types");
        intResult.Should().Be("42", "formatter shouldn't affect primitive types");
    }

    [Fact]
    public void Formatter_WithComplexObject_ShouldApplyToAllProperties()
    {
        // Setup
        var formatter = new Func<PropertyInfo, string>(prop => prop.Name.ToLowerInvariant());
        var sut = new QueryStringBuilder(formatter);
        var obj = new TestNestedObject
        {
            Outer = "test",
            Inner = new TestObject { StringProp = "nested" }
        };

        // Act
        var result = sut.FormatQueryParam(obj);

        // Assert
        result.Should().Contain("outer:");
        result.Should().Contain("inner:");
        result.Should().Contain("stringprop:");
    }

    #endregion

    #region Test Helpers

    public class TestObject
    {
        public string? StringProp { get; set; }
        public int? IntProp { get; set; }
        public bool? BoolProp { get; set; }
    }

    public class TestNestedObject
    {
        public string? Outer { get; set; }
        public TestObject? Inner { get; set; }
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum TestEnum
    {
        // ReSharper disable once UnusedMember.Global
        ValueOne,
        ValueTwo
    }

    #endregion
}
