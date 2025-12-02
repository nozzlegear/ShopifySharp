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

public class HasLocalizedFieldsQueryBuilder() : GraphQueryBuilder<IHasLocalizedFields>("hasLocalizedFields")
{
    public HasLocalizedFieldsQueryBuilder AddFieldLocalizedFields(Func<LocalizedFieldConnectionQueryBuilder, LocalizedFieldConnectionQueryBuilder> build)
    {
        AddField<LocalizedFieldConnection, LocalizedFieldConnectionQueryBuilder>("localizedFields", build);
        return this;
    }
}