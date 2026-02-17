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
    public sealed class SubscriptionLocalDeliveryOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionLocalDeliveryOption, SubscriptionLocalDeliveryOptionQueryBuilder>
    {
        protected override SubscriptionLocalDeliveryOptionQueryBuilder Self => this;

        public SubscriptionLocalDeliveryOptionQueryBuilder() : this("subscriptionLocalDeliveryOption")
        {
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder(string name) : base(new Query<SubscriptionLocalDeliveryOption>(name))
        {
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder(IQuery<SubscriptionLocalDeliveryOption> query) : base(query)
        {
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder PhoneRequired()
        {
            base.InnerQuery.AddField("phoneRequired");
            return this;
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionLocalDeliveryOptionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}