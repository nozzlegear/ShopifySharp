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
    public sealed class ShopifyPaymentsDisputeEdgeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeEdge, ShopifyPaymentsDisputeEdgeQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeEdgeQueryBuilder Self => this;

        public ShopifyPaymentsDisputeEdgeQueryBuilder() : this("shopifyPaymentsDisputeEdge")
        {
        }

        public ShopifyPaymentsDisputeEdgeQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeEdge>(name))
        {
        }

        public ShopifyPaymentsDisputeEdgeQueryBuilder(IQuery<ShopifyPaymentsDisputeEdge> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopifyPaymentsDisputeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }
    }
}