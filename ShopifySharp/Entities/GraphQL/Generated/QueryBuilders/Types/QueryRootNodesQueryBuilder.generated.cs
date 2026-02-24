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
    public sealed class QueryRootNodesQueryBuilder : FieldsQueryBuilderBase<INode, QueryRootNodesQueryBuilder>, IHasArguments<QueryRootNodesArgumentsBuilder>
    {
        public QueryRootNodesArgumentsBuilder Arguments { get; }
        protected override QueryRootNodesQueryBuilder Self => this;

        public QueryRootNodesQueryBuilder(string name) : base(new Query<INode>(name))
        {
            Arguments = new QueryRootNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodesQueryBuilder(IQuery<INode> query) : base(query)
        {
            Arguments = new QueryRootNodesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodesQueryBuilder SetArguments(Action<QueryRootNodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootNodesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}