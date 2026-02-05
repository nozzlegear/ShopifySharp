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
    public sealed class SubscriptionBillingCycleEditedContractQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleEditedContract, SubscriptionBillingCycleEditedContractQueryBuilder>
    {
        protected override SubscriptionBillingCycleEditedContractQueryBuilder Self => this;

        public SubscriptionBillingCycleEditedContractQueryBuilder() : this("subscriptionBillingCycleEditedContract")
        {
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleEditedContract>(name))
        {
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder(IQuery<SubscriptionBillingCycleEditedContract> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder AppAdminUrl()
        {
            base.InnerQuery.AddField("appAdminUrl");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder BillingCycles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleConnection>("billingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleConnection>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder Discounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscountConnection>(query);
            return this;
        }

        [Obsolete("Use `linesCount` instead.")]
        public SubscriptionBillingCycleEditedContractQueryBuilder LineCount()
        {
            base.InnerQuery.AddField("lineCount");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder Lines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder LinesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("linesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SubscriptionBillingCycleEditedContractQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}