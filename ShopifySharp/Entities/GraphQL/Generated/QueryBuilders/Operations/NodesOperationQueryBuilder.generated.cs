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
    public sealed class NodesOperationQueryBuilder : FieldsQueryBuilderBase<INode, NodesOperationQueryBuilder>, IGraphOperationQueryBuilder<INode>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public NodesArgumentsBuilder Arguments { get; }
        protected override NodesOperationQueryBuilder Self => this;

        public NodesOperationQueryBuilder() : this("nodes")
        {
        }

        public NodesOperationQueryBuilder(string name) : base(new Query<INode>(name))
        {
            Arguments = new NodesArgumentsBuilder(base.InnerQuery);
        }

        public NodesOperationQueryBuilder(IQuery<INode> query) : base(query)
        {
            Arguments = new NodesArgumentsBuilder(base.InnerQuery);
        }

        public NodesOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}