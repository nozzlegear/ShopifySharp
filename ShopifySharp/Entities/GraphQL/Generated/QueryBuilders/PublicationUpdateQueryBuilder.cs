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

public class PublicationUpdateQueryBuilder() : GraphQueryBuilder<PublicationUpdatePayload>("query publicationUpdate")
{
    public PublicationUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public PublicationUpdateQueryBuilder AddArgumentInput(PublicationUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}