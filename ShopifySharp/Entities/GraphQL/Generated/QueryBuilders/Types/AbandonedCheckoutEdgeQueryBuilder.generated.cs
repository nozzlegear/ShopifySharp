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
    public sealed class AbandonedCheckoutEdgeQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutEdge, AbandonedCheckoutEdgeQueryBuilder>
    {
        protected override AbandonedCheckoutEdgeQueryBuilder Self => this;

        public AbandonedCheckoutEdgeQueryBuilder() : this("abandonedCheckoutEdge")
        {
        }

        public AbandonedCheckoutEdgeQueryBuilder(string name) : base(new Query<AbandonedCheckoutEdge>(name))
        {
        }

        public AbandonedCheckoutEdgeQueryBuilder(IQuery<AbandonedCheckoutEdge> query) : base(query)
        {
        }

        public AbandonedCheckoutEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AbandonedCheckoutEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }
    }
}