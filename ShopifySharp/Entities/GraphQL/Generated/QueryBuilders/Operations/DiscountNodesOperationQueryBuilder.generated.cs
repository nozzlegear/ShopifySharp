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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountNodesOperationQueryBuilder : FieldsQueryBuilderBase<DiscountNodeConnection, DiscountNodesOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountNodeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DiscountNodesArgumentsBuilder Arguments { get; }
        protected override DiscountNodesOperationQueryBuilder Self => this;

        public DiscountNodesOperationQueryBuilder() : this("discountNodes")
        {
        }

        public DiscountNodesOperationQueryBuilder(string name) : base(new Query<DiscountNodeConnection>(name))
        {
            Arguments = new DiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountNodesOperationQueryBuilder(IQuery<DiscountNodeConnection> query) : base(query)
        {
            Arguments = new DiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountNodesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNodeEdge>(query);
            return this;
        }

        public DiscountNodesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNode>(query);
            return this;
        }

        public DiscountNodesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}