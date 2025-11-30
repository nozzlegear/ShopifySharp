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

public class MetaobjectUpdatePayloadQueryBuilder() : GraphQueryBuilder<MetaobjectUpdatePayload>("metaobjectUpdatePayload")
{
    public MetaobjectUpdatePayloadQueryBuilder AddFieldMetaobject(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddField<Metaobject, MetaobjectQueryBuilder>("metaobject", build);
        return this;
    }

    public MetaobjectUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MetaobjectUserErrorQueryBuilder, MetaobjectUserErrorQueryBuilder> build)
    {
        AddField<MetaobjectUserError, MetaobjectUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}