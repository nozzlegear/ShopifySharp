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
    public sealed class NodeQueryBuilder : FieldsQueryBuilderBase<INode, NodeQueryBuilder>
    {
        protected override NodeQueryBuilder Self => this;

        public NodeQueryBuilder() : this("node")
        {
        }

        public NodeQueryBuilder(string name) : base(new Query<INode>(name))
        {
        }

        public NodeQueryBuilder(IQuery<INode> query) : base(query)
        {
        }

        public NodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}