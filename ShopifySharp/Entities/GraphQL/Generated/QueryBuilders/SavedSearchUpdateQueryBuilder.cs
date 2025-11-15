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

public class SavedSearchUpdateQueryBuilder() : GraphQueryBuilder<SavedSearchUpdatePayload>("query savedSearchUpdate")
{
    public SavedSearchUpdateQueryBuilder AddArgumentInput(SavedSearchUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}