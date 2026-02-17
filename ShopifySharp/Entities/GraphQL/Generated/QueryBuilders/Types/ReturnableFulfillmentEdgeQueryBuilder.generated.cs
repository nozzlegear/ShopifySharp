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
    public sealed class ReturnableFulfillmentEdgeQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentEdge, ReturnableFulfillmentEdgeQueryBuilder>
    {
        protected override ReturnableFulfillmentEdgeQueryBuilder Self => this;

        public ReturnableFulfillmentEdgeQueryBuilder() : this("returnableFulfillmentEdge")
        {
        }

        public ReturnableFulfillmentEdgeQueryBuilder(string name) : base(new Query<ReturnableFulfillmentEdge>(name))
        {
        }

        public ReturnableFulfillmentEdgeQueryBuilder(IQuery<ReturnableFulfillmentEdge> query) : base(query)
        {
        }

        public ReturnableFulfillmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReturnableFulfillmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillment>(query);
            return this;
        }
    }
}