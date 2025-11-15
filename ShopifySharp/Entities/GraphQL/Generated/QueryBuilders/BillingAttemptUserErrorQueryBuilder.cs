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

public class BillingAttemptUserErrorQueryBuilder() : GraphQueryBuilder<BillingAttemptUserError>("query billingAttemptUserError")
{
    public BillingAttemptUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public BillingAttemptUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public BillingAttemptUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}