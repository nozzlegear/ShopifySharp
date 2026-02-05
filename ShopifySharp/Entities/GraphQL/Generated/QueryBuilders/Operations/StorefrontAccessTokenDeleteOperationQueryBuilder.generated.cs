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
    public sealed class StorefrontAccessTokenDeleteOperationQueryBuilder : FieldsQueryBuilderBase<StorefrontAccessTokenDeletePayload, StorefrontAccessTokenDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<StorefrontAccessTokenDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StorefrontAccessTokenDeleteArgumentsBuilder Arguments { get; }
        protected override StorefrontAccessTokenDeleteOperationQueryBuilder Self => this;

        public StorefrontAccessTokenDeleteOperationQueryBuilder() : this("storefrontAccessTokenDelete")
        {
        }

        public StorefrontAccessTokenDeleteOperationQueryBuilder(string name) : base(new Query<StorefrontAccessTokenDeletePayload>(name))
        {
            Arguments = new StorefrontAccessTokenDeleteArgumentsBuilder(base.InnerQuery);
        }

        public StorefrontAccessTokenDeleteOperationQueryBuilder(IQuery<StorefrontAccessTokenDeletePayload> query) : base(query)
        {
            Arguments = new StorefrontAccessTokenDeleteArgumentsBuilder(base.InnerQuery);
        }

        public StorefrontAccessTokenDeleteOperationQueryBuilder DeletedStorefrontAccessTokenId()
        {
            base.InnerQuery.AddField("deletedStorefrontAccessTokenId");
            return this;
        }

        public StorefrontAccessTokenDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}