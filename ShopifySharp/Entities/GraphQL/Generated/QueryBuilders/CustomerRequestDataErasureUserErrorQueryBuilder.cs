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

public class CustomerRequestDataErasureUserErrorQueryBuilder() : GraphQueryBuilder<CustomerRequestDataErasureUserError>("query customerRequestDataErasureUserError")
{
    public CustomerRequestDataErasureUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerRequestDataErasureUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerRequestDataErasureUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}