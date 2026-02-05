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
    public sealed class ErrorsWebPixelUserErrorQueryBuilder : FieldsQueryBuilderBase<ErrorsWebPixelUserError, ErrorsWebPixelUserErrorQueryBuilder>
    {
        protected override ErrorsWebPixelUserErrorQueryBuilder Self => this;

        public ErrorsWebPixelUserErrorQueryBuilder() : this("errorsWebPixelUserError")
        {
        }

        public ErrorsWebPixelUserErrorQueryBuilder(string name) : base(new Query<ErrorsWebPixelUserError>(name))
        {
        }

        public ErrorsWebPixelUserErrorQueryBuilder(IQuery<ErrorsWebPixelUserError> query) : base(query)
        {
        }

        public ErrorsWebPixelUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ErrorsWebPixelUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ErrorsWebPixelUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}