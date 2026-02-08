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
    public sealed class UrlRedirectUserErrorQueryBuilder : FieldsQueryBuilderBase<UrlRedirectUserError, UrlRedirectUserErrorQueryBuilder>
    {
        protected override UrlRedirectUserErrorQueryBuilder Self => this;

        public UrlRedirectUserErrorQueryBuilder() : this("urlRedirectUserError")
        {
        }

        public UrlRedirectUserErrorQueryBuilder(string name) : base(new Query<UrlRedirectUserError>(name))
        {
        }

        public UrlRedirectUserErrorQueryBuilder(IQuery<UrlRedirectUserError> query) : base(query)
        {
        }

        public UrlRedirectUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public UrlRedirectUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public UrlRedirectUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}