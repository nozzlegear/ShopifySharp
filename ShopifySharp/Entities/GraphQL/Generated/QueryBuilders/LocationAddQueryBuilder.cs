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

public class LocationAddQueryBuilder() : GraphQueryBuilder<LocationAddPayload>("query locationAdd")
{
    public LocationAddQueryBuilder AddArgumentInput(LocationAddInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}