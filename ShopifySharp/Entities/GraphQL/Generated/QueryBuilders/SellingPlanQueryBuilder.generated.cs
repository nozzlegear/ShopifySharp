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

public class SellingPlanQueryBuilder() : GraphQueryBuilder<SellingPlan>("sellingPlan")
{
    public SellingPlanQueryBuilder AddUnionCaseBillingPolicy(Func<SellingPlanFixedBillingPolicyQueryBuilder, SellingPlanFixedBillingPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanFixedBillingPolicy, SellingPlanFixedBillingPolicyQueryBuilder>("billingPolicy", build);
        return this;
    }

    public SellingPlanQueryBuilder AddUnionCaseBillingPolicy(Func<SellingPlanRecurringBillingPolicyQueryBuilder, SellingPlanRecurringBillingPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanRecurringBillingPolicy, SellingPlanRecurringBillingPolicyQueryBuilder>("billingPolicy", build);
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

    public SellingPlanQueryBuilder AddUnionCaseDeliveryPolicy(Func<SellingPlanFixedDeliveryPolicyQueryBuilder, SellingPlanFixedDeliveryPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanFixedDeliveryPolicy, SellingPlanFixedDeliveryPolicyQueryBuilder>("deliveryPolicy", build);
        return this;
    }

    public SellingPlanQueryBuilder AddUnionCaseDeliveryPolicy(Func<SellingPlanRecurringDeliveryPolicyQueryBuilder, SellingPlanRecurringDeliveryPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanRecurringDeliveryPolicy, SellingPlanRecurringDeliveryPolicyQueryBuilder>("deliveryPolicy", build);
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

    public SellingPlanQueryBuilder AddFieldInventoryPolicy(Func<SellingPlanInventoryPolicyQueryBuilder, SellingPlanInventoryPolicyQueryBuilder> build)
    {
        AddField<SellingPlanInventoryPolicy, SellingPlanInventoryPolicyQueryBuilder>("inventoryPolicy", build);
        return this;
    }

    public SellingPlanQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public SellingPlanQueryBuilder AddFieldMetafieldDefinitions(Func<MetafieldDefinitionConnectionQueryBuilder, MetafieldDefinitionConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConnection, MetafieldDefinitionConnectionQueryBuilder>("metafieldDefinitions", build);
        return this;
    }

    public SellingPlanQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
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

    public SellingPlanQueryBuilder AddUnionCasePricingPolicies(Func<SellingPlanFixedPricingPolicyQueryBuilder, SellingPlanFixedPricingPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanFixedPricingPolicy, SellingPlanFixedPricingPolicyQueryBuilder>("pricingPolicies", build);
        return this;
    }

    public SellingPlanQueryBuilder AddUnionCasePricingPolicies(Func<SellingPlanRecurringPricingPolicyQueryBuilder, SellingPlanRecurringPricingPolicyQueryBuilder> build)
    {
        AddUnion<SellingPlanRecurringPricingPolicy, SellingPlanRecurringPricingPolicyQueryBuilder>("pricingPolicies", build);
        return this;
    }

    public SellingPlanQueryBuilder AddFieldTranslations(Func<TranslationQueryBuilder, TranslationQueryBuilder> build)
    {
        AddField<Translation, TranslationQueryBuilder>("translations", build);
        return this;
    }
}