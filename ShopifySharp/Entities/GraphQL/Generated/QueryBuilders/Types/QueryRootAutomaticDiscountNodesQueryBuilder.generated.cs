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
    public sealed class QueryRootAutomaticDiscountNodesQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticNodeConnection, QueryRootAutomaticDiscountNodesQueryBuilder>, IHasArguments<QueryRootAutomaticDiscountNodesArgumentsBuilder>
    {
        public QueryRootAutomaticDiscountNodesArgumentsBuilder Arguments { get; }
        protected override QueryRootAutomaticDiscountNodesQueryBuilder Self => this;

        public QueryRootAutomaticDiscountNodesQueryBuilder(string name) : base(new Query<DiscountAutomaticNodeConnection>(name))
        {
            Arguments = new QueryRootAutomaticDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAutomaticDiscountNodesQueryBuilder(IQuery<DiscountAutomaticNodeConnection> query) : base(query)
        {
            Arguments = new QueryRootAutomaticDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAutomaticDiscountNodesQueryBuilder SetArguments(Action<QueryRootAutomaticDiscountNodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAutomaticDiscountNodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNodeEdge>(query);
            return this;
        }

        public QueryRootAutomaticDiscountNodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public QueryRootAutomaticDiscountNodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}