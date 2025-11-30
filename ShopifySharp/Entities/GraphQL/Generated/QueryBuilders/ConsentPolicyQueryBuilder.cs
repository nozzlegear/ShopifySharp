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

public class ConsentPolicyQueryBuilder() : GraphQueryBuilder<ConsentPolicy>("query consentPolicy")
{
    public ConsentPolicyQueryBuilder AddArgumentConsentRequired(bool? consentRequired)
    {
        AddArgument("consentRequired", consentRequired);
        return this;
    }

    public ConsentPolicyQueryBuilder AddArgumentCountryCode(PrivacyCountryCode? countryCode)
    {
        AddArgument("countryCode", countryCode);
        return this;
    }

    public ConsentPolicyQueryBuilder AddArgumentDataSaleOptOutRequired(bool? dataSaleOptOutRequired)
    {
        AddArgument("dataSaleOptOutRequired", dataSaleOptOutRequired);
        return this;
    }

    public ConsentPolicyQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ConsentPolicyQueryBuilder AddArgumentRegionCode(string? regionCode)
    {
        AddArgument("regionCode", regionCode);
        return this;
    }
}