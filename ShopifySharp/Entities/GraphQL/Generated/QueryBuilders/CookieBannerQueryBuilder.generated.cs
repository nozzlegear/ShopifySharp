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

public class CookieBannerQueryBuilder() : GraphQueryBuilder<CookieBanner>("cookieBanner")
{
    public CookieBannerQueryBuilder AddFieldAutoManaged()
    {
        AddField("autoManaged");
        return this;
    }

    public CookieBannerQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }

    public CookieBannerQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }
}