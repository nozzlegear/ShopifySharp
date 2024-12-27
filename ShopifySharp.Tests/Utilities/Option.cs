using System;

namespace ShopifySharp.Tests.Utilities;

public readonly struct Option<T>
{
    private readonly T _value;
    private readonly bool _isSome;

    private Option(T value, bool isSome)
    {
        _value = value;
        _isSome = isSome;
    }

    public bool IsSome => _isSome;
    public bool IsNone => !_isSome;

    public T Value => _isSome
        ? _value
        : throw new InvalidOperationException("Cannot access the value of None.");

    public static Option<T> Some(T value) => new(value, true);
    public static Option<T> None() => new(default, false);

    public override string ToString() =>
        IsSome ? $"Some({_value})" : "None";
}
