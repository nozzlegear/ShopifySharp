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
    public sealed class QueryRootNodeQueryBuilder : FieldsQueryBuilderBase<INode, QueryRootNodeQueryBuilder>, IHasArguments<QueryRootNodeArgumentsBuilder>
    {
        public QueryRootNodeArgumentsBuilder Arguments { get; }
        protected override QueryRootNodeQueryBuilder Self => this;

        public QueryRootNodeQueryBuilder(string name) : base(new Query<INode>(name))
        {
            Arguments = new QueryRootNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodeQueryBuilder(IQuery<INode> query) : base(query)
        {
            Arguments = new QueryRootNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootNodeQueryBuilder SetArguments(Action<QueryRootNodeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootNodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}