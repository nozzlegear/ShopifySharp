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

public class PriceRuleLineItemPrerequisitesQueryBuilder() : GraphQueryBuilder<PriceRuleLineItemPrerequisites>("priceRuleLineItemPrerequisites")
{
    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldCollections(Func<CollectionConnectionQueryBuilder, CollectionConnectionQueryBuilder> build)
    {
        AddField<CollectionConnection, CollectionConnectionQueryBuilder>("collections", build);
        return this;
    }

    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldProducts(Func<ProductConnectionQueryBuilder, ProductConnectionQueryBuilder> build)
    {
        AddField<ProductConnection, ProductConnectionQueryBuilder>("products", build);
        return this;
    }

    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("productVariants", build);
        return this;
    }
}