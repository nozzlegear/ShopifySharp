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
    public sealed class ErrorsServerPixelUserErrorQueryBuilder : FieldsQueryBuilderBase<ErrorsServerPixelUserError, ErrorsServerPixelUserErrorQueryBuilder>
    {
        protected override ErrorsServerPixelUserErrorQueryBuilder Self => this;

        public ErrorsServerPixelUserErrorQueryBuilder() : this("errorsServerPixelUserError")
        {
        }

        public ErrorsServerPixelUserErrorQueryBuilder(string name) : base(new Query<ErrorsServerPixelUserError>(name))
        {
        }

        public ErrorsServerPixelUserErrorQueryBuilder(IQuery<ErrorsServerPixelUserError> query) : base(query)
        {
        }

        public ErrorsServerPixelUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ErrorsServerPixelUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ErrorsServerPixelUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}