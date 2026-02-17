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

        public StorefrontAccessTokenDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}