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
    public sealed class NodeOperationQueryBuilder : FieldsQueryBuilderBase<INode, NodeOperationQueryBuilder>, IGraphOperationQueryBuilder<INode>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public NodeArgumentsBuilder Arguments { get; }
        protected override NodeOperationQueryBuilder Self => this;

        public NodeOperationQueryBuilder() : this("node")
        {
        }

        public NodeOperationQueryBuilder(string name) : base(new Query<INode>(name))
        {
            Arguments = new NodeArgumentsBuilder(base.InnerQuery);
        }

        public NodeOperationQueryBuilder(IQuery<INode> query) : base(query)
        {
            Arguments = new NodeArgumentsBuilder(base.InnerQuery);
        }

        public NodeOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}