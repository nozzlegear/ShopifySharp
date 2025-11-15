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

public class CustomerSendAccountInviteEmailPayloadQueryBuilder() : GraphQueryBuilder<CustomerSendAccountInviteEmailPayload>("query customerSendAccountInviteEmailPayload")
{
    public CustomerSendAccountInviteEmailPayloadQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public CustomerSendAccountInviteEmailPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}