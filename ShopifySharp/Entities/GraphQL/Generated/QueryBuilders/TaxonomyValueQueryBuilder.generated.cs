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

public class TaxonomyValueQueryBuilder() : GraphQueryBuilder<TaxonomyValue>("taxonomyValue")
{
    public TaxonomyValueQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TaxonomyValueQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}