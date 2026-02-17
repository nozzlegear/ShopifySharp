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
    public sealed class ReturnableFulfillmentConnectionQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentConnection, ReturnableFulfillmentConnectionQueryBuilder>
    {
        protected override ReturnableFulfillmentConnectionQueryBuilder Self => this;

        public ReturnableFulfillmentConnectionQueryBuilder() : this("returnableFulfillmentConnection")
        {
        }

        public ReturnableFulfillmentConnectionQueryBuilder(string name) : base(new Query<ReturnableFulfillmentConnection>(name))
        {
        }

        public ReturnableFulfillmentConnectionQueryBuilder(IQuery<ReturnableFulfillmentConnection> query) : base(query)
        {
        }

        public ReturnableFulfillmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentEdge>(query);
            return this;
        }

        public ReturnableFulfillmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillment>(query);
            return this;
        }

        public ReturnableFulfillmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}