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

public class LocationEditQueryBuilder() : GraphQueryBuilder<LocationEditPayload>("query locationEdit")
{
    public LocationEditQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public LocationEditQueryBuilder AddArgumentInput(LocationEditInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}