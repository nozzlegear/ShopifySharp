using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace ShopifySharp.Tests.Extensions;

/// <summary>
/// Extensions which provide assertions to objects that can be empty (strings and IEnumerables).
/// </summary>
public static class EmptyExtensions
{
    public static void NullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source == null || !source.Any())
        {
            return;
        }

        throw new NotNullOrEmptyException();
    }

    public static void NotNullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source == null || !source.Any())
        {
            throw new NullOrEmptyException();
        }
    }
}

public class NotNullOrEmptyException() : Exception($"Target was not null or empty.");

public class NullOrEmptyException() : Exception("Target was null or empty.");

#nullable enable

public enum ReflectedMemberType
{
    Field,
    Property
}

public record ReflectedMember
{
    private readonly object _parent;
    public readonly ReflectedMemberType ReflectedMemberType;
    public readonly FieldInfo? Field;
    public readonly PropertyInfo? Property;

    public ReflectedMember(object parent, FieldInfo? field)
    {
        _parent = parent;
        ReflectedMemberType = ReflectedMemberType.Field;
        Field = field;
        Property = null;
    }

    public ReflectedMember(object parent, PropertyInfo? propertyInfo)
    {
        _parent = parent;
        ReflectedMemberType = ReflectedMemberType.Property;
        Field = null;
        Property = propertyInfo;
    }

    public string? GetName() => ReflectedMemberType == ReflectedMemberType.Field
        ? Field?.Name
        : Property?.Name;

    public object? GetValue() => ReflectedMemberType == ReflectedMemberType.Field
        ? Field?.GetValue(_parent)
        : Property?.GetValue(_parent);

    public Type? GetFieldOrPropertyType() => ReflectedMemberType == ReflectedMemberType.Field
        ? Field?.FieldType
        : Property?.PropertyType;

    public AssertionScope CreateScope() => new(nameof(ReflectedMember));
}

public static class ObjectAssertionExtensions
{
    private static AndConstraint<ReflectedFieldAssertions> HaveFieldOrProperty(
        this ObjectAssertions assertion,
        string expectedName,
        BindingFlags bindingFlags,
        string because = "",
        params object[] becauseArgs
    )
    {
        var subjectType = assertion.Subject.GetType();
        var memberInfo = subjectType.GetMember(expectedName, bindingFlags);

        memberInfo.Should()
            .HaveCountGreaterThan(0, because, becauseArgs);

        var member = memberInfo.First();
        var reflectedMember = member.MemberType switch
        {
            MemberTypes.Field => new ReflectedMember(assertion.Subject, (FieldInfo)member),
            MemberTypes.Property => new ReflectedMember(assertion.Subject, (PropertyInfo)member),
            _ => throw new ArgumentException($"Unhandled {nameof(member.MemberType)} value {member.MemberType}.")
        };

        return new ReflectedFieldAssertions(reflectedMember)
            .NotBeNull(because, becauseArgs)
            .And
            .HaveName(expectedName, because, becauseArgs);
    }

    [CustomAssertion]
    public static AndConstraint<ReflectedFieldAssertions> HavePrivateMember(this ObjectAssertions assertion, string expectedName, string because = "", params object[] becauseArgs)
    {
        return HaveFieldOrProperty(assertion,
            expectedName,
            BindingFlags.NonPublic | BindingFlags.Instance,
            because,
            becauseArgs);
    }

    [CustomAssertion]
    public static AndConstraint<ReflectedFieldAssertions> HavePublicMember(this ObjectAssertions assertion, string expectedName, string because = "", params object[] becauseArgs)
    {
        return HaveFieldOrProperty(assertion,
            expectedName,
            BindingFlags.Public | BindingFlags.Instance,
            because,
            becauseArgs);
    }
}

public class ReflectedFieldAssertions(ReflectedMember subject)
{
    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> NotBeNull(string because = "", params object[] becauseArgs)
    {
        using var scope = subject.CreateScope();
        var exists = subject.ReflectedMemberType == ReflectedMemberType.Field ? subject.Field is not null : subject.Property is not null;

        scope.BecauseOf(because, becauseArgs)
            .ForCondition(exists)
            .FailWith("Expected {context} to exist, but found <null>.");

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> HaveName(string expectedName, string because = "", params object[] becauseArgs)
    {
        NotBeNull(because, becauseArgs);

        using var scope = subject.CreateScope();
        var actualName = subject.ReflectedMemberType == ReflectedMemberType.Field ? subject.Field?.Name : subject.Property?.Name;

        scope.BecauseOf(because, becauseArgs)
            .ForCondition(actualName == expectedName)
            .FailWith("Expected {context} to have name {0}, but found {1}.", expectedName, actualName);

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public AndWhichConstraint<ReflectedFieldAssertions, T?> BeOfType<T>(string because = "", params object[] becauseArgs)
    {
        NotBeNull(because, becauseArgs);

        using var scope = subject.CreateScope();
        var subjectType = subject.GetFieldOrPropertyType();

        scope.BecauseOf(because, becauseArgs)
            .ForCondition(subjectType is not null)
            .FailWith("Expected {context} to have {0}, but found <null>.", subject.ReflectedMemberType)
            .Then
            .ForCondition(subjectType == typeof(T))
            .FailWith("Expected type of {context} value to be {0}, but found {1}.", typeof(T), subjectType);

        var subjectValue = (T?) subject.GetValue();

        return new AndWhichConstraint<ReflectedFieldAssertions, T?>(this, subjectValue);
    }

    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> BeOfGenericType<T>(string because = "", params object[] becauseArgs)
    {
        NotBeNull(because, becauseArgs);

        using var scope = subject.CreateScope();
        var subjectType = subject.GetFieldOrPropertyType();
        var expectedType = typeof(T);

        scope.BecauseOf(because, becauseArgs)
            .ForCondition(subjectType is not null)
            .FailWith("Expected {context} to have {0}, but found <null>.", subject.ReflectedMemberType)
            .Then
            .BecauseOf(because, becauseArgs)
            .ForCondition(subjectType!.IsGenericTypeDefinition)
            .FailWith("Expected type of {context} to be a generic type definition, but it is not generic.")
            .Then
            .BecauseOf(because, becauseArgs)
            .Given(() => subjectType.GetGenericTypeDefinition())
            .ForCondition(actualGenericType => actualGenericType == expectedType)
            .FailWith(
                "Expected generic type of {context} to be {0}, but found {1}",
                (_) => expectedType,
                (actualType) => actualType
            );

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> HaveValue<T>(T? expectedValue, string because = "", params object[] becauseArgs)
        where T: IEquatable<T>
    {
        using var scope = subject.CreateScope();
        NotBeNull(because, becauseArgs);
        BeOfType<T>(because, becauseArgs);

        var subjectValue = subject.GetValue();
        var assertion = scope.BecauseOf(because, becauseArgs);

        if (expectedValue is null)
        {
            assertion.ForCondition(subjectValue is null)
                .FailWith("Expected {context} to have value <null>, but found {0}.", subjectValue);
        }
        else
        {
            assertion.ForCondition(subjectValue is not null && subjectValue.Equals(expectedValue))
                .FailWith("Expected {context} to have value {0}, but found {1}", expectedValue, subjectValue);
        }

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }
}
