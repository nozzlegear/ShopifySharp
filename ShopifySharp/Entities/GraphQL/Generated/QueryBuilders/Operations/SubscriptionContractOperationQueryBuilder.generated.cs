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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SubscriptionContractOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContract, SubscriptionContractOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContract>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionContractArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractOperationQueryBuilder Self => this;

        public SubscriptionContractOperationQueryBuilder() : this("subscriptionContract")
        {
        }

        public SubscriptionContractOperationQueryBuilder(string name) : base(new Query<SubscriptionContract>(name))
        {
            Arguments = new SubscriptionContractArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractOperationQueryBuilder(IQuery<SubscriptionContract> query) : base(query)
        {
            Arguments = new SubscriptionContractArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractOperationQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder AppAdminUrl()
        {
            base.InnerQuery.AddField("appAdminUrl");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder BillingAttempts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("billingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder BillingPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingPolicy>("billingPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingPolicy>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder DeliveryPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryPolicy>("deliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryPolicy>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Discounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscountConnection>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder LastBillingAttemptErrorType()
        {
            base.InnerQuery.AddField("lastBillingAttemptErrorType");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder LastPaymentStatus()
        {
            base.InnerQuery.AddField("lastPaymentStatus");
            return this;
        }

        [Obsolete("Use `linesCount` instead.")]
        public SubscriptionContractOperationQueryBuilder LineCount()
        {
            base.InnerQuery.AddField("lineCount");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Lines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder LinesCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("linesCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder NextBillingDate()
        {
            base.InnerQuery.AddField("nextBillingDate");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder OriginOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("originOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public SubscriptionContractOperationQueryBuilder RevisionId()
        {
            base.InnerQuery.AddField("revisionId");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SubscriptionContractOperationQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}