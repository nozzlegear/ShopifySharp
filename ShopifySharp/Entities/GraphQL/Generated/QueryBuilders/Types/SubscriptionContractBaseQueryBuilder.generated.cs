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
    public sealed class SubscriptionContractBaseQueryBuilder : FieldsQueryBuilderBase<ISubscriptionContractBase, SubscriptionContractBaseQueryBuilder>
    {
        protected override SubscriptionContractBaseQueryBuilder Self => this;

        public SubscriptionContractBaseQueryBuilder() : this("subscriptionContractBase")
        {
        }

        public SubscriptionContractBaseQueryBuilder(string name) : base(new Query<ISubscriptionContractBase>(name))
        {
        }

        public SubscriptionContractBaseQueryBuilder(IQuery<ISubscriptionContractBase> query) : base(query)
        {
        }

        public SubscriptionContractBaseQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder AppAdminUrl()
        {
            base.InnerQuery.AddField("appAdminUrl");
            return this;
        }

        public SubscriptionContractBaseQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public SubscriptionContractBaseQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder DeliveryPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("deliveryPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder Discounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscountConnection>("discounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscountConnection>(query);
            return this;
        }

        [Obsolete("Use `linesCount` instead.")]
        public SubscriptionContractBaseQueryBuilder LineCount()
        {
            base.InnerQuery.AddField("lineCount");
            return this;
        }

        public SubscriptionContractBaseQueryBuilder Lines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder LinesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("linesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public SubscriptionContractBaseQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public SubscriptionContractBaseQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SubscriptionContractBaseQueryBuilder DeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("deliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}