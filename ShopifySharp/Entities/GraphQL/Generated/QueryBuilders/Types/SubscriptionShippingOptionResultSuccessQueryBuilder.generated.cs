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
    public sealed class SubscriptionShippingOptionResultSuccessQueryBuilder : FieldsQueryBuilderBase<SubscriptionShippingOptionResultSuccess, SubscriptionShippingOptionResultSuccessQueryBuilder>
    {
        protected override SubscriptionShippingOptionResultSuccessQueryBuilder Self => this;

        public SubscriptionShippingOptionResultSuccessQueryBuilder() : this("subscriptionShippingOptionResultSuccess")
        {
        }

        public SubscriptionShippingOptionResultSuccessQueryBuilder(string name) : base(new Query<SubscriptionShippingOptionResultSuccess>(name))
        {
        }

        public SubscriptionShippingOptionResultSuccessQueryBuilder(IQuery<SubscriptionShippingOptionResultSuccess> query) : base(query)
        {
        }

        public SubscriptionShippingOptionResultSuccessQueryBuilder ShippingOptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionShippingOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionShippingOption>("shippingOptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionShippingOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionShippingOption>(query);
            return this;
        }
    }
}