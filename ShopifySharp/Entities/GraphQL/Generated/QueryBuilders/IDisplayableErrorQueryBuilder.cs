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

public class IDisplayableErrorQueryBuilder() : GraphQueryBuilder<IDisplayableError>("query iDisplayableError")
{
    public IDisplayableErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public IDisplayableErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}