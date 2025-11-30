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

public class SellingPlanQueryBuilder() : GraphQueryBuilder<SellingPlan>("query sellingPlan")
{
    public SellingPlanQueryBuilder AddFieldBillingPolicy()
    {
        AddField("billingPolicy");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldCategory()
    {
        AddField("category");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldDeliveryPolicy()
    {
        AddField("deliveryPolicy");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldInventoryPolicy()
    {
        AddField("inventoryPolicy");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public SellingPlanQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldOptions()
    {
        AddField("options");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldPricingPolicies()
    {
        AddField("pricingPolicies");
        return this;
    }

    public SellingPlanQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }
}