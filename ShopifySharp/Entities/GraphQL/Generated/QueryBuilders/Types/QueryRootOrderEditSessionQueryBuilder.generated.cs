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
    public sealed class QueryRootOrderEditSessionQueryBuilder : FieldsQueryBuilderBase<OrderEditSession, QueryRootOrderEditSessionQueryBuilder>, IHasArguments<QueryRootOrderEditSessionArgumentsBuilder>
    {
        public QueryRootOrderEditSessionArgumentsBuilder Arguments { get; }
        protected override QueryRootOrderEditSessionQueryBuilder Self => this;

        public QueryRootOrderEditSessionQueryBuilder(string name) : base(new Query<OrderEditSession>(name))
        {
            Arguments = new QueryRootOrderEditSessionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderEditSessionQueryBuilder(IQuery<OrderEditSession> query) : base(query)
        {
            Arguments = new QueryRootOrderEditSessionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrderEditSessionQueryBuilder SetArguments(Action<QueryRootOrderEditSessionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootOrderEditSessionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}