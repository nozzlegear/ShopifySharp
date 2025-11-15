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

public class SubscriptionBillingCycleQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycle>("query subscriptionBillingCycle")
{
    public SubscriptionBillingCycleQueryBuilder AddFieldBillingAttemptExpectedDate()
    {
        AddField("billingAttemptExpectedDate");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldBillingAttempts()
    {
        AddField("billingAttempts");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldCycleEndAt()
    {
        AddField("cycleEndAt");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldCycleIndex()
    {
        AddField("cycleIndex");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldCycleStartAt()
    {
        AddField("cycleStartAt");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldEdited()
    {
        AddField("edited");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldEditedContract()
    {
        AddField("editedContract");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldSkipped()
    {
        AddField("skipped");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldSourceContract()
    {
        AddField("sourceContract");
        return this;
    }

    public SubscriptionBillingCycleQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}