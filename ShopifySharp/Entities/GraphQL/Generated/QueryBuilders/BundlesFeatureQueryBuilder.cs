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

public class BundlesFeatureQueryBuilder() : GraphQueryBuilder<BundlesFeature>("query bundlesFeature")
{
    public BundlesFeatureQueryBuilder AddFieldEligibleForBundles()
    {
        AddField("eligibleForBundles");
        return this;
    }

    public BundlesFeatureQueryBuilder AddFieldIneligibilityReason()
    {
        AddField("ineligibilityReason");
        return this;
    }

    public BundlesFeatureQueryBuilder AddFieldSellsBundles()
    {
        AddField("sellsBundles");
        return this;
    }
}