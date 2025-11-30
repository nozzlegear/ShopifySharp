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

public class MetaobjectBulkDeleteQueryBuilder() : GraphQueryBuilder<MetaobjectBulkDeletePayload>("query metaobjectBulkDelete")
{
    public MetaobjectBulkDeleteQueryBuilder AddArgumentWhere(MetaobjectBulkDeleteWhereCondition? @where)
    {
        AddArgument("where", @where);
        return this;
    }
}