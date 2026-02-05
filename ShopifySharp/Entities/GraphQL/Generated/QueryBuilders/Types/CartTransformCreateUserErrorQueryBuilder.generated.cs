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
    public sealed class CartTransformCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<CartTransformCreateUserError, CartTransformCreateUserErrorQueryBuilder>
    {
        protected override CartTransformCreateUserErrorQueryBuilder Self => this;

        public CartTransformCreateUserErrorQueryBuilder() : this("cartTransformCreateUserError")
        {
        }

        public CartTransformCreateUserErrorQueryBuilder(string name) : base(new Query<CartTransformCreateUserError>(name))
        {
        }

        public CartTransformCreateUserErrorQueryBuilder(IQuery<CartTransformCreateUserError> query) : base(query)
        {
        }

        public CartTransformCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CartTransformCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CartTransformCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}