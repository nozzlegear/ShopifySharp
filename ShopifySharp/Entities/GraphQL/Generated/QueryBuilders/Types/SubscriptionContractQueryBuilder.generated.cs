#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SubscriptionContractQueryBuilder : FieldsQueryBuilderBase<SubscriptionContract, SubscriptionContractQueryBuilder>
    {
        protected override SubscriptionContractQueryBuilder Self => this;

        public SubscriptionContractQueryBuilder() : this("subscriptionContract")
        {
        }

        public SubscriptionContractQueryBuilder(string name) : base(new Query<SubscriptionContract>(name))
        {
        }

        public SubscriptionContractQueryBuilder(IQuery<SubscriptionContract> query) : base(query)
        {
        }

        public SubscriptionContractQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder AppAdminUrl()
        {
            base.InnerQuery.AddField("appAdminUrl");
            return this;
        }

        public SubscriptionContractQueryBuilder BillingAttempts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("billingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder BillingPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingPolicy>("billingPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingPolicy>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SubscriptionContractQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public SubscriptionContractQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder DeliveryPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryPolicy>("deliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryPolicy>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder Discounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscountConnection>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionContractQueryBuilder LastBillingAttemptErrorType()
        {
            base.InnerQuery.AddField("lastBillingAttemptErrorType");
            return this;
        }

        public SubscriptionContractQueryBuilder LastPaymentStatus()
        {
            base.InnerQuery.AddField("lastPaymentStatus");
            return this;
        }

        [Obsolete("Use `linesCount` instead.")]
        public SubscriptionContractQueryBuilder LineCount()
        {
            base.InnerQuery.AddField("lineCount");
            return this;
        }

        public SubscriptionContractQueryBuilder Lines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder LinesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("linesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder NextBillingDate()
        {
            base.InnerQuery.AddField("nextBillingDate");
            return this;
        }

        public SubscriptionContractQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public SubscriptionContractQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder OriginOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("originOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public SubscriptionContractQueryBuilder RevisionId()
        {
            base.InnerQuery.AddField("revisionId");
            return this;
        }

        public SubscriptionContractQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public SubscriptionContractQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SubscriptionContractQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}