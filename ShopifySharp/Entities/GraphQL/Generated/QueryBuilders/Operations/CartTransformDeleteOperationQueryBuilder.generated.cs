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
    public sealed class CartTransformDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CartTransformDeletePayload, CartTransformDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CartTransformDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CartTransformDeleteArgumentsBuilder Arguments { get; }
        protected override CartTransformDeleteOperationQueryBuilder Self => this;

        public CartTransformDeleteOperationQueryBuilder() : this("cartTransformDelete")
        {
        }

        public CartTransformDeleteOperationQueryBuilder(string name) : base(new Query<CartTransformDeletePayload>(name))
        {
            Arguments = new CartTransformDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformDeleteOperationQueryBuilder(IQuery<CartTransformDeletePayload> query) : base(query)
        {
            Arguments = new CartTransformDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CartTransformDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CartTransformDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformDeleteUserError>(query);
            return this;
        }
    }
}