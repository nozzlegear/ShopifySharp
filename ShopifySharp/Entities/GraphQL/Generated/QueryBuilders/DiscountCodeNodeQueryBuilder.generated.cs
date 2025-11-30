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

public class DiscountCodeNodeQueryBuilder() : GraphQueryBuilder<DiscountCodeNode>("discountCodeNode")
{
    public DiscountCodeNodeQueryBuilder AddUnionCaseCodeDiscount(Func<DiscountCodeAppQueryBuilder, DiscountCodeAppQueryBuilder> build)
    {
        AddUnion<DiscountCodeApp, DiscountCodeAppQueryBuilder>("codeDiscount", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddUnionCaseCodeDiscount(Func<DiscountCodeBasicQueryBuilder, DiscountCodeBasicQueryBuilder> build)
    {
        AddUnion<DiscountCodeBasic, DiscountCodeBasicQueryBuilder>("codeDiscount", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddUnionCaseCodeDiscount(Func<DiscountCodeBxgyQueryBuilder, DiscountCodeBxgyQueryBuilder> build)
    {
        AddUnion<DiscountCodeBxgy, DiscountCodeBxgyQueryBuilder>("codeDiscount", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddUnionCaseCodeDiscount(Func<DiscountCodeFreeShippingQueryBuilder, DiscountCodeFreeShippingQueryBuilder> build)
    {
        AddUnion<DiscountCodeFreeShipping, DiscountCodeFreeShippingQueryBuilder>("codeDiscount", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldEvents(Func<EventConnectionQueryBuilder, EventConnectionQueryBuilder> build)
    {
        AddField<EventConnection, EventConnectionQueryBuilder>("events", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldMetafieldDefinitions(Func<MetafieldDefinitionConnectionQueryBuilder, MetafieldDefinitionConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConnection, MetafieldDefinitionConnectionQueryBuilder>("metafieldDefinitions", build);
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }
}