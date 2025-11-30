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

public class SellingPlanGroupQueryBuilder() : GraphQueryBuilder<SellingPlanGroup>("sellingPlanGroup")
{
    public SellingPlanGroupQueryBuilder AddFieldAppId()
    {
        AddField("appId");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldAppliesToProduct()
    {
        AddField("appliesToProduct");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldAppliesToProductVariant()
    {
        AddField("appliesToProductVariant");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldAppliesToProductVariants()
    {
        AddField("appliesToProductVariants");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldMerchantCode()
    {
        AddField("merchantCode");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldOptions()
    {
        AddField("options");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProducts(Func<ProductConnectionQueryBuilder, ProductConnectionQueryBuilder> build)
    {
        AddField<ProductConnection, ProductConnectionQueryBuilder>("products", build);
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("productsCount", build);
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("productVariants", build);
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductVariantsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("productVariantsCount", build);
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldSellingPlans(Func<SellingPlanConnectionQueryBuilder, SellingPlanConnectionQueryBuilder> build)
    {
        AddField<SellingPlanConnection, SellingPlanConnectionQueryBuilder>("sellingPlans", build);
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }
}