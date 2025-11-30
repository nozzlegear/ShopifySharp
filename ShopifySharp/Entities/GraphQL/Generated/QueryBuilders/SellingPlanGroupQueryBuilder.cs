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

public class SellingPlanGroupQueryBuilder() : GraphQueryBuilder<SellingPlanGroup>("query sellingPlanGroup")
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

    public SellingPlanGroupQueryBuilder AddFieldProducts()
    {
        AddField("products");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductsCount()
    {
        AddField("productsCount");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldProductVariantsCount()
    {
        AddField("productVariantsCount");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldSellingPlans()
    {
        AddField("sellingPlans");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public SellingPlanGroupQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }
}