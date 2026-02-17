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
    public sealed class DelegateAccessTokenCreateOperationQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenCreatePayload, DelegateAccessTokenCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DelegateAccessTokenCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DelegateAccessTokenCreateArgumentsBuilder Arguments { get; }
        protected override DelegateAccessTokenCreateOperationQueryBuilder Self => this;

        public DelegateAccessTokenCreateOperationQueryBuilder() : this("delegateAccessTokenCreate")
        {
        }

        public DelegateAccessTokenCreateOperationQueryBuilder(string name) : base(new Query<DelegateAccessTokenCreatePayload>(name))
        {
            Arguments = new DelegateAccessTokenCreateArgumentsBuilder(base.InnerQuery);
        }

        public DelegateAccessTokenCreateOperationQueryBuilder(IQuery<DelegateAccessTokenCreatePayload> query) : base(query)
        {
            Arguments = new DelegateAccessTokenCreateArgumentsBuilder(base.InnerQuery);
        }

        public DelegateAccessTokenCreateOperationQueryBuilder DelegateAccessToken(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenQueryBuilder> build)
        {
            var query = new Query<DelegateAccessToken>("delegateAccessToken");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessToken>(query);
            return this;
        }

        public DelegateAccessTokenCreateOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public DelegateAccessTokenCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<DelegateAccessTokenCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessTokenCreateUserError>(query);
            return this;
        }
    }
}