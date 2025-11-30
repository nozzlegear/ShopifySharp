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

public class ProductBundleCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductBundleCreatePayload>("productBundleCreatePayload")
{
    public ProductBundleCreatePayloadQueryBuilder AddFieldProductBundleOperation(Func<ProductBundleOperationQueryBuilder, ProductBundleOperationQueryBuilder> build)
    {
        AddField<ProductBundleOperation, ProductBundleOperationQueryBuilder>("productBundleOperation", build);
        return this;
    }

    public ProductBundleCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}