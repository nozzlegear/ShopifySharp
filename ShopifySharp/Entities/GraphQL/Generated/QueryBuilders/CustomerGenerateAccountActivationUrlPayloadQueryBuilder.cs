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

public class CustomerGenerateAccountActivationUrlPayloadQueryBuilder() : GraphQueryBuilder<CustomerGenerateAccountActivationUrlPayload>("query customerGenerateAccountActivationUrlPayload")
{
    public CustomerGenerateAccountActivationUrlPayloadQueryBuilder AddFieldAccountActivationUrl()
    {
        AddField("accountActivationUrl");
        return this;
    }

    public CustomerGenerateAccountActivationUrlPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}