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

public class CustomerSendAccountInviteEmailUserErrorQueryBuilder() : GraphQueryBuilder<CustomerSendAccountInviteEmailUserError>("query customerSendAccountInviteEmailUserError")
{
    public CustomerSendAccountInviteEmailUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerSendAccountInviteEmailUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerSendAccountInviteEmailUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}