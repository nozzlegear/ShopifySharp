#nullable enable
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace ShopifySharp.Infrastructure.Serialization.Json;

// TODO: make this public
internal interface IJsonSerializer
{
    IJsonElement Parse(string value);

    string Serialize<T>(T item);

    void Serialize(IJsonWriter writer,
        object? value,
        [MeansImplicitUse(ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature, ImplicitUseTargetFlags.WithMembers)]
        Type inputType);

    ValueTask SerializeAsync<T>(Stream target, T item, CancellationToken cancellationToken = default);

    object? Deserialize(IJsonElement jsonElement, Type type);

    T? Deserialize<T>(IJsonElement jsonElement);

    ValueTask<object?> DeserializeAsync(IJsonElement jsonElement, Type type, CancellationToken cancellationToken = default);

    ValueTask<T?> DeserializeAsync<T>(IJsonElement jsonElement, CancellationToken cancellationToken = default);
}
