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
    public sealed class CodeDiscountNodesOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNodeConnection, CodeDiscountNodesOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeNodeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CodeDiscountNodesArgumentsBuilder Arguments { get; }
        protected override CodeDiscountNodesOperationQueryBuilder Self => this;

        public CodeDiscountNodesOperationQueryBuilder() : this("codeDiscountNodes")
        {
        }

        public CodeDiscountNodesOperationQueryBuilder(string name) : base(new Query<DiscountCodeNodeConnection>(name))
        {
            Arguments = new CodeDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodesOperationQueryBuilder(IQuery<DiscountCodeNodeConnection> query) : base(query)
        {
            Arguments = new CodeDiscountNodesArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNodeEdge>(query);
            return this;
        }

        public CodeDiscountNodesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public CodeDiscountNodesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}