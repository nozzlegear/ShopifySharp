using System;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreatedMetafield(string Id, string Key, string? Namespace, string Value)
{
    public static CreatedMetafield FromGraph(GraphQL.Metafield? metafield)
    {
        ArgumentNullException.ThrowIfNull(metafield, nameof(metafield));
        var m = metafield!;

        return new CreatedMetafield(
            m.id ?? "",
            m.key ?? "",
            m.@namespace ?? "",
            m.value ?? ""
        );
    }
}
