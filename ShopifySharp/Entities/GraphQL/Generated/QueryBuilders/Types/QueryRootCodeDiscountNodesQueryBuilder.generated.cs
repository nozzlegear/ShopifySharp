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
    public sealed class QueryRootCodeDiscountNodesQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNodeConnection, QueryRootCodeDiscountNodesQueryBuilder>, IHasArguments<QueryRootCodeDiscountNodesArgumentsBuilder>
    {
        public QueryRootCodeDiscountNodesArgumentsBuilder Arguments { get; }
        protected override QueryRootCodeDiscountNodesQueryBuilder Self => this;

        public QueryRootCodeDiscountNodesQueryBuilder(string name) : base(new Query<DiscountCodeNodeConnection>(name))
        {
            Arguments = new QueryRootCodeDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodesQueryBuilder(IQuery<DiscountCodeNodeConnection> query) : base(query)
        {
            Arguments = new QueryRootCodeDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodesQueryBuilder SetArguments(Action<QueryRootCodeDiscountNodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCodeDiscountNodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNodeEdge>(query);
            return this;
        }

        public QueryRootCodeDiscountNodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public QueryRootCodeDiscountNodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}