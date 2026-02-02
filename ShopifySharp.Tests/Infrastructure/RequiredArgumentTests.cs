#nullable enable
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "Infrastructure")]
[TestSubject(typeof(RequiredArgument))]
public class RequiredArgumentTests
{
    #region NotNull Tests

    [Fact]
    public void NotNull_WithNullReferenceType_ShouldThrowArgumentNullException()
    {
        // Setup
        string? nullString = null;

        // Act
        var act = () => RequiredArgument.NotNull(nullString, nameof(nullString));

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(nullString));
    }

    [Fact]
    public void NotNull_WithNullNullableValueType_ShouldThrowArgumentNullException()
    {
        // Setup
        int? nullInt = null;

        // Act
        var act = () => RequiredArgument.NotNull(nullInt, nameof(nullInt));

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(nullInt));
    }

    [Fact]
    public void NotNull_WithValidReferenceType_ShouldNotThrow()
    {
        // Setup
        string validString = "test";

        // Act
        var act = () => RequiredArgument.NotNull(validString, nameof(validString));

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void NotNull_WithValidNullableValueType_ShouldNotThrow()
    {
        // Setup
        int? validInt = 42;

        // Act
        var act = () => RequiredArgument.NotNull(validInt, nameof(validInt));

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void NotNull_ExceptionShouldContainCorrectParameterName()
    {
        // Setup
        object? nullObject = null;
        const string parameterName = "mySpecialParameter";

        // Act
        var act = () => RequiredArgument.NotNull(nullObject, parameterName);

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName(parameterName);
    }

    [Fact]
    public void NotNull_WithEmptyString_ShouldNotThrow()
    {
        // Setup
        string emptyString = string.Empty;

        // Act
        var act = () => RequiredArgument.NotNull(emptyString, nameof(emptyString));

        // Assert
        act.Should().NotThrow("empty strings are not null");
    }

    [Fact]
    public void NotNull_WithWhitespaceString_ShouldNotThrow()
    {
        // Setup
        string whitespaceString = "   ";

        // Act
        var act = () => RequiredArgument.NotNull(whitespaceString, nameof(whitespaceString));

        // Assert
        act.Should().NotThrow("whitespace strings are not null");
    }

    [Fact]
    public void NotNull_WithZeroValue_ShouldNotThrow()
    {
        // Setup
        int zero = 0;

        // Act
        var act = () => RequiredArgument.NotNull(zero, nameof(zero));

        // Assert
        act.Should().NotThrow("zero is a valid value, not null");
    }

    #endregion

    #region NotNullOrEmpty Tests

    [Fact]
    public void NotNullOrEmpty_WithNullString_ShouldThrowArgumentNullException()
    {
        // Setup
        string? nullString = null;

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(nullString, nameof(nullString));

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(nullString));
    }

    [Fact]
    public void NotNullOrEmpty_WithEmptyString_ShouldThrowArgumentException()
    {
        // Setup
        string emptyString = string.Empty;

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(emptyString, nameof(emptyString));

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithParameterName(nameof(emptyString))
            .WithMessage("Value cannot be empty.*");
    }

    [Fact]
    public void NotNullOrEmpty_ExceptionMessageShouldSayValueCannotBeEmpty()
    {
        // Setup
        string emptyString = string.Empty;

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(emptyString, nameof(emptyString));

        // Assert
        act.Should().Throw<ArgumentException>()
            .Where(ex => ex.Message.Contains("Value cannot be empty."));
    }

    [Fact]
    public void NotNullOrEmpty_WithValidString_ShouldNotThrow()
    {
        // Setup
        string validString = "test";

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(validString, nameof(validString));

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void NotNullOrEmpty_WithWhitespaceString_ShouldNotThrow()
    {
        // Setup
        string whitespaceString = "   ";

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(whitespaceString, nameof(whitespaceString));

        // Assert
        act.Should().NotThrow("whitespace is not empty, even though it may be undesirable");
    }

    [Fact]
    public void NotNullOrEmpty_WithSingleCharacter_ShouldNotThrow()
    {
        // Setup
        string singleChar = "a";

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(singleChar, nameof(singleChar));

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void NotNullOrEmpty_ExceptionShouldContainCorrectParameterName()
    {
        // Setup
        string emptyString = string.Empty;
        const string parameterName = "mySpecialStringParameter";

        // Act
        var act = () => RequiredArgument.NotNullOrEmpty(emptyString, parameterName);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithParameterName(parameterName);
    }

    #endregion
}
