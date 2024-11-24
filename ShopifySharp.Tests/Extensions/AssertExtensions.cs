using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using FluentAssertions.Types;

namespace ShopifySharp.Tests.Extensions;

/// <summary>
/// Extensions which provide assertions to objects that can be empty (strings and IEnumerables).
/// </summary>
public static class EmptyExtensions
{
    public static void NullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source == null || source.Count() == 0)
        {
            return;
        }

        throw new NotNullOrEmptyException(source);
    }

    public static void NotNullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source == null || source.Count() == 0)
        {
            throw new NullOrEmptyException(source);
        }
    }
}

public class NotNullOrEmptyException : Exception
{
    public object Target { get; }

    public NotNullOrEmptyException(object target) : base($"Target was not null or empty.")
    {
        this.Target = target;
    }   
}

public class NullOrEmptyException : Exception
{
    public object Target { get; }

    public NullOrEmptyException(object target) : base("Target was null or empty.")
    {
        this.Target = target;
    }
}

#nullable enable

public record ReflectedField(object Parent, FieldInfo? Field)
{
    public object Parent { get; } = Parent;
    public FieldInfo? Field { get; } = Field;
}

public static class ReflectedFieldAssertionExtensions
{
    public static ReflectedFieldAssertions Should(this FieldInfo? instance, object parent)
    {
        return new ReflectedFieldAssertions(new ReflectedField(parent, instance));
    }
}

public static class TypeAssertionExtensions
{
    public static AndConstraint<ReflectedFieldAssertions> HavePrivateField(this TypeAssertions assertion, string expectedName, object instance, string because = "", params object[] becauseArgs)
    {
        var field = assertion.Subject.GetField(expectedName, BindingFlags.NonPublic | BindingFlags.Instance);
        return new ReflectedFieldAssertions(new ReflectedField(instance, field))
            .Exist(because, becauseArgs)
            .And
            .HaveName(expectedName, because, becauseArgs);
    }
}

public class ReflectedFieldAssertions(ReflectedField instance)
    : ReferenceTypeAssertions<ReflectedField, ReflectedFieldAssertions>(instance)
{
    protected override string Identifier => "reflected-field";

    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> Exist(string because = "", params object[] becauseArgs)
    {
        Execute.Assertion
            .BecauseOf(because, becauseArgs)
            .ForCondition(Subject.Field is not null)
            .FailWith("Expected field to exist, but found <null>.");

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public AndConstraint<ReflectedFieldAssertions> HaveName(string expectedName, string because = "", params object[] becauseArgs)
    {
        Execute.Assertion
            .BecauseOf(because, becauseArgs)
            .ForCondition(Subject.Field is not null)
            .FailWith("Expected field to exist, but found <null>.")
            .Then
            .Given(() => Subject.Field)
            .ForCondition(field => field?.Name == expectedName)
            .FailWith("Expected field to have name {0}, but found {1}.", _ => expectedName, field => field?.Name);

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public new AndConstraint<ReflectedFieldAssertions> BeOfType<T>(string because = "", params object[] becauseArgs)
    {
        NotBeNull(because, becauseArgs);

        var success = Execute.Assertion
            .BecauseOf(because, becauseArgs)
            .ForCondition(Subject.Field is not null)
            .FailWith("Expected field to exist, but found <null>.");

        if (success)
        {
            var expectedType = typeof(T);
            var subjectType = Subject.Field!.FieldType;

            if (expectedType.IsGenericTypeDefinition && subjectType.IsGenericTypeDefinition)
            {
                subjectType.GetGenericTypeDefinition().Should().Be(expectedType, because, becauseArgs);
            }
            else
            {
                subjectType.Should().Be(expectedType, because, becauseArgs);
            }
        }

        return new AndConstraint<ReflectedFieldAssertions>(this);
    }

    [CustomAssertion]
    public AndWhichConstraint<ReflectedFieldAssertions, T?> HaveValue<T>(T? expectedValue, string because = "", params object[] becauseArgs)
        where T: IEquatable<T>
    {
        NotBeNull(because, becauseArgs);

        var subjectValue = (T?) Subject.Field?.GetValue(Subject.Parent);

        if (expectedValue is null)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(subjectValue is null)
                .FailWith("Expected field value to be <null>, but found {0}.", subjectValue);
        }
        else
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(subjectValue is not null && subjectValue.Equals(expectedValue))
                .FailWith("Expected field value to be {0}, but found {1}", expectedValue, subjectValue);
        }

        return new AndWhichConstraint<ReflectedFieldAssertions, T?>(this, subjectValue);
    }
}
