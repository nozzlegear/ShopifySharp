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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `discountNodes` instead.")]
    public sealed class AutomaticDiscountNodesOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticNodeConnection, AutomaticDiscountNodesOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticNodeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AutomaticDiscountNodesArgumentsBuilder Arguments { get; }
        protected override AutomaticDiscountNodesOperationQueryBuilder Self => this;

        public AutomaticDiscountNodesOperationQueryBuilder() : this("automaticDiscountNodes")
        {
        }

        public AutomaticDiscountNodesOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticNodeConnection>(name))
        {
            Arguments = new AutomaticDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountNodesOperationQueryBuilder(IQuery<DiscountAutomaticNodeConnection> query) : base(query)
        {
            Arguments = new AutomaticDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountNodesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNodeEdge>(query);
            return this;
        }

        public AutomaticDiscountNodesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public AutomaticDiscountNodesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}