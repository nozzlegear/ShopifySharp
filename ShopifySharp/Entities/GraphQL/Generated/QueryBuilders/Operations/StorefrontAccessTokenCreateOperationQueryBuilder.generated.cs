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
    public sealed class StorefrontAccessTokenCreateOperationQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenCreatePayload, StorefrontAccessTokenCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<StorefrontAccessTokenCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StorefrontAccessTokenCreateArgumentsBuilder Arguments { get; }
        protected override StorefrontAccessTokenCreateOperationQueryBuilder Self => this;

        public StorefrontAccessTokenCreateOperationQueryBuilder() : this("storefrontAccessTokenCreate")
        {
        }

        public StorefrontAccessTokenCreateOperationQueryBuilder(string name) : base(new Query<StorefrontAccessTokenCreatePayload>(name))
        {
            Arguments = new StorefrontAccessTokenCreateArgumentsBuilder(base.InnerQuery);
        }

        public StorefrontAccessTokenCreateOperationQueryBuilder(IQuery<StorefrontAccessTokenCreatePayload> query) : base(query)
        {
            Arguments = new StorefrontAccessTokenCreateArgumentsBuilder(base.InnerQuery);
        }

        public StorefrontAccessTokenCreateOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public StorefrontAccessTokenCreateOperationQueryBuilder StorefrontAccessToken(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder> build)
        {
            var query = new Query<StorefrontAccessToken>("storefrontAccessToken");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StorefrontAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StorefrontAccessToken>(query);
            return this;
        }

        public StorefrontAccessTokenCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}