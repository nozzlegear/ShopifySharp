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
    public sealed class UrlRedirectOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirect, UrlRedirectOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirect>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public UrlRedirectArgumentsBuilder Arguments { get; }
        protected override UrlRedirectOperationQueryBuilder Self => this;

        public UrlRedirectOperationQueryBuilder() : this("urlRedirect")
        {
        }

        public UrlRedirectOperationQueryBuilder(string name) : base(new Query<UrlRedirect>(name))
        {
            Arguments = new UrlRedirectArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectOperationQueryBuilder(IQuery<UrlRedirect> query) : base(query)
        {
            Arguments = new UrlRedirectArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UrlRedirectOperationQueryBuilder Path()
        {
            base.InnerQuery.AddField("path");
            return this;
        }

        public UrlRedirectOperationQueryBuilder Target()
        {
            base.InnerQuery.AddField("target");
            return this;
        }
    }
}