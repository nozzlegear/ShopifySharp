#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class PrivacyFeaturesDisableUserErrorQueryBuilder() : GraphQueryBuilder<PrivacyFeaturesDisableUserError>("privacyFeaturesDisableUserError")
{
    public PrivacyFeaturesDisableUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PrivacyFeaturesDisableUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PrivacyFeaturesDisableUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}