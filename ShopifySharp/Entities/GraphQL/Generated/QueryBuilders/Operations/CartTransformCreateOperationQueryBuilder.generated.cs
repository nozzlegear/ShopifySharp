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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CartTransformCreateOperationQueryBuilder : FieldsQueryBuilderBase<CartTransformCreatePayload, CartTransformCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CartTransformCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CartTransformCreateArgumentsBuilder Arguments { get; }
        protected override CartTransformCreateOperationQueryBuilder Self => this;

        public CartTransformCreateOperationQueryBuilder() : this("cartTransformCreate")
        {
        }

        public CartTransformCreateOperationQueryBuilder(string name) : base(new Query<CartTransformCreatePayload>(name))
        {
            Arguments = new CartTransformCreateArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformCreateOperationQueryBuilder(IQuery<CartTransformCreatePayload> query) : base(query)
        {
            Arguments = new CartTransformCreateArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformCreateOperationQueryBuilder CartTransform(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("cartTransform");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransform>(query);
            return this;
        }

        public CartTransformCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CartTransformCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformCreateUserError>(query);
            return this;
        }
    }
}