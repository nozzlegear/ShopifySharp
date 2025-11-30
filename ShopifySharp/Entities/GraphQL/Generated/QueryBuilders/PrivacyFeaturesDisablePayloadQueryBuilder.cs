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

public class PrivacyFeaturesDisablePayloadQueryBuilder() : GraphQueryBuilder<PrivacyFeaturesDisablePayload>("query privacyFeaturesDisablePayload")
{
    public PrivacyFeaturesDisablePayloadQueryBuilder AddFieldFeaturesDisabled()
    {
        AddField("featuresDisabled");
        return this;
    }

    public PrivacyFeaturesDisablePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}