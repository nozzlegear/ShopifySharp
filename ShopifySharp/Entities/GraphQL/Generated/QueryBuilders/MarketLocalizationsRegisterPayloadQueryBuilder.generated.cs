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

public class MarketLocalizationsRegisterPayloadQueryBuilder() : GraphQueryBuilder<MarketLocalizationsRegisterPayload>("marketLocalizationsRegisterPayload")
{
    public MarketLocalizationsRegisterPayloadQueryBuilder AddFieldMarketLocalizations(Func<MarketLocalizationQueryBuilder, MarketLocalizationQueryBuilder> build)
    {
        AddField<MarketLocalization, MarketLocalizationQueryBuilder>("marketLocalizations", build);
        return this;
    }

    public MarketLocalizationsRegisterPayloadQueryBuilder AddFieldUserErrors(Func<TranslationUserErrorQueryBuilder, TranslationUserErrorQueryBuilder> build)
    {
        AddField<TranslationUserError, TranslationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}