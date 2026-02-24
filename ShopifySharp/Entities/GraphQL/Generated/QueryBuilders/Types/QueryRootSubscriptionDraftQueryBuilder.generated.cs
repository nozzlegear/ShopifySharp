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
    public sealed class QueryRootSubscriptionDraftQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraft, QueryRootSubscriptionDraftQueryBuilder>, IHasArguments<QueryRootSubscriptionDraftArgumentsBuilder>
    {
        public QueryRootSubscriptionDraftArgumentsBuilder Arguments { get; }
        protected override QueryRootSubscriptionDraftQueryBuilder Self => this;

        public QueryRootSubscriptionDraftQueryBuilder(string name) : base(new Query<SubscriptionDraft>(name))
        {
            Arguments = new QueryRootSubscriptionDraftArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionDraftQueryBuilder(IQuery<SubscriptionDraft> query) : base(query)
        {
            Arguments = new QueryRootSubscriptionDraftArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionDraftQueryBuilder SetArguments(Action<QueryRootSubscriptionDraftArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder BillingPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingPolicy>("billingPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingPolicy>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder ConcatenatedBillingCycles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleConnection>("concatenatedBillingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DeliveryPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryPolicy>("deliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryPolicy>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Discounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DiscountsAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DiscountsRemoved(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DiscountsUpdated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountConnection>("discountsUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Lines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder LinesAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("linesAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder LinesRemoved(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("linesRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder NextBillingDate()
        {
            base.InnerQuery.AddField("nextBillingDate");
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder OriginalContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("originalContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public QueryRootSubscriptionDraftQueryBuilder DeliveryOptions(Action<SubscriptionDeliveryOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResult>("deliveryOptions");
            var unionBuilder = new SubscriptionDeliveryOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `deliveryOptions` instead.")]
        public QueryRootSubscriptionDraftQueryBuilder ShippingOptions(Action<SubscriptionShippingOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResult>("shippingOptions");
            var unionBuilder = new SubscriptionShippingOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}