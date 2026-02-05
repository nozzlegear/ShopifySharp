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
    public sealed class CartTransformDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CartTransformDeletePayload, CartTransformDeletePayloadQueryBuilder>
    {
        protected override CartTransformDeletePayloadQueryBuilder Self => this;

        public CartTransformDeletePayloadQueryBuilder() : this("cartTransformDeletePayload")
        {
        }

        public CartTransformDeletePayloadQueryBuilder(string name) : base(new Query<CartTransformDeletePayload>(name))
        {
        }

        public CartTransformDeletePayloadQueryBuilder(IQuery<CartTransformDeletePayload> query) : base(query)
        {
        }

        public CartTransformDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CartTransformDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CartTransformDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformDeleteUserError>(query);
            return this;
        }
    }
}