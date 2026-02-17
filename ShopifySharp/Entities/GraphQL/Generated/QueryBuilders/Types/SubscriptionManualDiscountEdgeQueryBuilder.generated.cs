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
    public sealed class SubscriptionManualDiscountEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionManualDiscountEdge, SubscriptionManualDiscountEdgeQueryBuilder>
    {
        protected override SubscriptionManualDiscountEdgeQueryBuilder Self => this;

        public SubscriptionManualDiscountEdgeQueryBuilder() : this("subscriptionManualDiscountEdge")
        {
        }

        public SubscriptionManualDiscountEdgeQueryBuilder(string name) : base(new Query<SubscriptionManualDiscountEdge>(name))
        {
        }

        public SubscriptionManualDiscountEdgeQueryBuilder(IQuery<SubscriptionManualDiscountEdge> query) : base(query)
        {
        }

        public SubscriptionManualDiscountEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionManualDiscountEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }
    }
}