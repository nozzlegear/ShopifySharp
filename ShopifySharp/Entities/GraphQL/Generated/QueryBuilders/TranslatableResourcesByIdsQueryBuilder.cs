#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TranslatableResourcesByIdsQueryBuilder() : GraphQueryBuilder<TranslatableResourceConnection>("query translatableResourcesByIds")
{
    public TranslatableResourcesByIdsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public TranslatableResourcesByIdsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public TranslatableResourcesByIdsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public TranslatableResourcesByIdsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public TranslatableResourcesByIdsQueryBuilder AddArgumentResourceIds(ICollection<string>? resourceIds)
    {
        AddArgument("resourceIds", resourceIds);
        return this;
    }

    public TranslatableResourcesByIdsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}