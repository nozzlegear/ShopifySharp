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
    public sealed class FulfillmentEventConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentEventConnection, FulfillmentEventConnectionQueryBuilder>
    {
        protected override FulfillmentEventConnectionQueryBuilder Self => this;

        public FulfillmentEventConnectionQueryBuilder() : this("fulfillmentEventConnection")
        {
        }

        public FulfillmentEventConnectionQueryBuilder(string name) : base(new Query<FulfillmentEventConnection>(name))
        {
        }

        public FulfillmentEventConnectionQueryBuilder(IQuery<FulfillmentEventConnection> query) : base(query)
        {
        }

        public FulfillmentEventConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventEdge>(query);
            return this;
        }

        public FulfillmentEventConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEvent>(query);
            return this;
        }

        public FulfillmentEventConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}