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

public class DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder() : GraphQueryBuilder<DraftOrderMarketRegionCountryCodeNotSupportedWarning>("draftOrderMarketRegionCountryCodeNotSupportedWarning")
{
    public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}