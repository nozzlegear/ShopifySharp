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
    public sealed class SubscriptionPickupOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionPickupOption, SubscriptionPickupOptionQueryBuilder>
    {
        protected override SubscriptionPickupOptionQueryBuilder Self => this;

        public SubscriptionPickupOptionQueryBuilder() : this("subscriptionPickupOption")
        {
        }

        public SubscriptionPickupOptionQueryBuilder(string name) : base(new Query<SubscriptionPickupOption>(name))
        {
        }

        public SubscriptionPickupOptionQueryBuilder(IQuery<SubscriptionPickupOption> query) : base(query)
        {
        }

        public SubscriptionPickupOptionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder PhoneRequired()
        {
            base.InnerQuery.AddField("phoneRequired");
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder PickupTime()
        {
            base.InnerQuery.AddField("pickupTime");
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionPickupOptionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}