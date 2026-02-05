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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class UrlRedirectQueryBuilder : FieldsQueryBuilderBase<UrlRedirect, UrlRedirectQueryBuilder>
    {
        protected override UrlRedirectQueryBuilder Self => this;

        public UrlRedirectQueryBuilder() : this("urlRedirect")
        {
        }

        public UrlRedirectQueryBuilder(string name) : base(new Query<UrlRedirect>(name))
        {
        }

        public UrlRedirectQueryBuilder(IQuery<UrlRedirect> query) : base(query)
        {
        }

        public UrlRedirectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UrlRedirectQueryBuilder Path()
        {
            base.InnerQuery.AddField("path");
            return this;
        }

        public UrlRedirectQueryBuilder Target()
        {
            base.InnerQuery.AddField("target");
            return this;
        }
    }
}