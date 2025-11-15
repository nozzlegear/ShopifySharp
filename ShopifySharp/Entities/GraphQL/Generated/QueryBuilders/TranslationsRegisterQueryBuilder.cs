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

public class TranslationsRegisterQueryBuilder() : GraphQueryBuilder<TranslationsRegisterPayload>("query translationsRegister")
{
    public TranslationsRegisterQueryBuilder AddArgumentResourceId(string? resourceId)
    {
        AddArgument("resourceId", resourceId);
        return this;
    }

    public TranslationsRegisterQueryBuilder AddArgumentTranslations(ICollection<TranslationInput>? translations)
    {
        AddArgument("translations", translations);
        return this;
    }
}