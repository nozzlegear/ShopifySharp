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

        public ShopifyPaymentsPayoutEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayout>(query);
            return this;
        }
    }
}