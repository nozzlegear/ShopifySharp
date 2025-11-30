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

public class HasLocalizationExtensionsQueryBuilder() : GraphQueryBuilder<IHasLocalizationExtensions>("hasLocalizationExtensions")
{
    public HasLocalizationExtensionsQueryBuilder AddFieldLocalizationExtensions(Func<LocalizationExtensionConnectionQueryBuilder, LocalizationExtensionConnectionQueryBuilder> build)
    {
        AddField<LocalizationExtensionConnection, LocalizationExtensionConnectionQueryBuilder>("localizationExtensions", build);
        return this;
    }
}