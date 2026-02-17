#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SubscriptionDraftQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraft, SubscriptionDraftQueryBuilder>
    {
        protected override SubscriptionDraftQueryBuilder Self => this;

        public SubscriptionDraftQueryBuilder() : this("subscriptionDraft")
        {
        }

        public SubscriptionDraftQueryBuilder(string name) : base(new Query<SubscriptionDraft>(name))
        {
        }

        public SubscriptionDraftQueryBuilder(IQuery<SubscriptionDraft> query) : base(query)
        {
        }

        public SubscriptionDraftQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder BillingPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingPolicy>("billingPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingPolicy>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder ConcatenatedBillingCycles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleConnection>("concatenatedBillingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public SubscriptionDraftQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DeliveryPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryPolicy>("deliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryPolicy>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder Discounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DiscountsAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DiscountsRemoved(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DiscountsUpdated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionDraftQueryBuilder Lines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder LinesAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("linesAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder LinesRemoved(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("linesRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder NextBillingDate()
        {
            base.InnerQuery.AddField("nextBillingDate");
            return this;
        }

        public SubscriptionDraftQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public SubscriptionDraftQueryBuilder OriginalContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("originalContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public SubscriptionDraftQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public SubscriptionDraftQueryBuilder DeliveryOptions(Action<SubscriptionDeliveryOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResult>("deliveryOptions");
            var unionBuilder = new SubscriptionDeliveryOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `deliveryOptions` instead.")]
        public SubscriptionDraftQueryBuilder ShippingOptions(Action<SubscriptionShippingOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResult>("shippingOptions");
            var unionBuilder = new SubscriptionShippingOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}