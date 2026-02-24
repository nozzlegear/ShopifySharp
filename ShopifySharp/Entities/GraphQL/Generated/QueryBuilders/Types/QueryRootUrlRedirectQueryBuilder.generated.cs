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
    public sealed class QueryRootUrlRedirectQueryBuilder : FieldsQueryBuilderBase<UrlRedirect, QueryRootUrlRedirectQueryBuilder>, IHasArguments<QueryRootUrlRedirectArgumentsBuilder>
    {
        public QueryRootUrlRedirectArgumentsBuilder Arguments { get; }
        protected override QueryRootUrlRedirectQueryBuilder Self => this;

        public QueryRootUrlRedirectQueryBuilder(string name) : base(new Query<UrlRedirect>(name))
        {
            Arguments = new QueryRootUrlRedirectArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectQueryBuilder(IQuery<UrlRedirect> query) : base(query)
        {
            Arguments = new QueryRootUrlRedirectArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectQueryBuilder SetArguments(Action<QueryRootUrlRedirectArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootUrlRedirectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootUrlRedirectQueryBuilder Path()
        {
            base.InnerQuery.AddField("path");
            return this;
        }

        public QueryRootUrlRedirectQueryBuilder Target()
        {
            base.InnerQuery.AddField("target");
            return this;
        }
    }
}