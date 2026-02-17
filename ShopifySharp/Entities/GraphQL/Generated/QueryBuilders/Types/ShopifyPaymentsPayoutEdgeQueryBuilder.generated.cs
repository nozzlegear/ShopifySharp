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
    public sealed class ShopifyPaymentsPayoutEdgeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutEdge, ShopifyPaymentsPayoutEdgeQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutEdgeQueryBuilder Self => this;

        public ShopifyPaymentsPayoutEdgeQueryBuilder() : this("shopifyPaymentsPayoutEdge")
        {
        }

        public ShopifyPaymentsPayoutEdgeQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutEdge>(name))
        {
        }

        public ShopifyPaymentsPayoutEdgeQueryBuilder(IQuery<ShopifyPaymentsPayoutEdge> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopifyPaymentsPayoutEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayout>(query);
            return this;
        }
    }
}