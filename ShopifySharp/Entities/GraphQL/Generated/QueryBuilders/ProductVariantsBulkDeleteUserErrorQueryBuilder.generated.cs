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

public class ProductVariantsBulkDeleteUserErrorQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkDeleteUserError>("productVariantsBulkDeleteUserError")
{
    public ProductVariantsBulkDeleteUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductVariantsBulkDeleteUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductVariantsBulkDeleteUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}