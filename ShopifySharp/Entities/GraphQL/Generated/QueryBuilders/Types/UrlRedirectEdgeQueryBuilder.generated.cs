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
    public sealed class UrlRedirectEdgeQueryBuilder : FieldsQueryBuilderBase<UrlRedirectEdge, UrlRedirectEdgeQueryBuilder>
    {
        protected override UrlRedirectEdgeQueryBuilder Self => this;

        public UrlRedirectEdgeQueryBuilder() : this("urlRedirectEdge")
        {
        }

        public UrlRedirectEdgeQueryBuilder(string name) : base(new Query<UrlRedirectEdge>(name))
        {
        }

        public UrlRedirectEdgeQueryBuilder(IQuery<UrlRedirectEdge> query) : base(query)
        {
        }

        public UrlRedirectEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public UrlRedirectEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }
    }
}