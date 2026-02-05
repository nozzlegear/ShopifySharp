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
    public sealed class FulfillmentConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentConnection, FulfillmentConnectionQueryBuilder>
    {
        protected override FulfillmentConnectionQueryBuilder Self => this;

        public FulfillmentConnectionQueryBuilder() : this("fulfillmentConnection")
        {
        }

        public FulfillmentConnectionQueryBuilder(string name) : base(new Query<FulfillmentConnection>(name))
        {
        }

        public FulfillmentConnectionQueryBuilder(IQuery<FulfillmentConnection> query) : base(query)
        {
        }

        public FulfillmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEdge>(query);
            return this;
        }

        public FulfillmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}