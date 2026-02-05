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
    public sealed class CartTransformDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<CartTransformDeleteUserError, CartTransformDeleteUserErrorQueryBuilder>
    {
        protected override CartTransformDeleteUserErrorQueryBuilder Self => this;

        public CartTransformDeleteUserErrorQueryBuilder() : this("cartTransformDeleteUserError")
        {
        }

        public CartTransformDeleteUserErrorQueryBuilder(string name) : base(new Query<CartTransformDeleteUserError>(name))
        {
        }

        public CartTransformDeleteUserErrorQueryBuilder(IQuery<CartTransformDeleteUserError> query) : base(query)
        {
        }

        public CartTransformDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CartTransformDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CartTransformDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}