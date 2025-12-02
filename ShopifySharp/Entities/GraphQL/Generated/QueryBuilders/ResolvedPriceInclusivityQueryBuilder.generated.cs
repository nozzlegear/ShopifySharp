#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ResolvedPriceInclusivityQueryBuilder() : GraphQueryBuilder<ResolvedPriceInclusivity>("resolvedPriceInclusivity")
{
    public ResolvedPriceInclusivityQueryBuilder AddFieldDutiesIncluded()
    {
        AddField("dutiesIncluded");
        return this;
    }

    public ResolvedPriceInclusivityQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }
}