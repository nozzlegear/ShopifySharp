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
    public sealed class SubscriptionDiscountEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountEdge, SubscriptionDiscountEdgeQueryBuilder>
    {
        protected override SubscriptionDiscountEdgeQueryBuilder Self => this;

        public SubscriptionDiscountEdgeQueryBuilder() : this("subscriptionDiscountEdge")
        {
        }

        public SubscriptionDiscountEdgeQueryBuilder(string name) : base(new Query<SubscriptionDiscountEdge>(name))
        {
        }

        public SubscriptionDiscountEdgeQueryBuilder(IQuery<SubscriptionDiscountEdge> query) : base(query)
        {
        }

        public SubscriptionDiscountEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionDiscountEdgeQueryBuilder Node(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("node");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}