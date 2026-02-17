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
    public sealed class DelegateAccessTokenDestroyOperationQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenDestroyPayload, DelegateAccessTokenDestroyOperationQueryBuilder>, IGraphOperationQueryBuilder<DelegateAccessTokenDestroyPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DelegateAccessTokenDestroyArgumentsBuilder Arguments { get; }
        protected override DelegateAccessTokenDestroyOperationQueryBuilder Self => this;

        public DelegateAccessTokenDestroyOperationQueryBuilder() : this("delegateAccessTokenDestroy")
        {
        }

        public DelegateAccessTokenDestroyOperationQueryBuilder(string name) : base(new Query<DelegateAccessTokenDestroyPayload>(name))
        {
            Arguments = new DelegateAccessTokenDestroyArgumentsBuilder(base.InnerQuery);
        }

        public DelegateAccessTokenDestroyOperationQueryBuilder(IQuery<DelegateAccessTokenDestroyPayload> query) : base(query)
        {
            Arguments = new DelegateAccessTokenDestroyArgumentsBuilder(base.InnerQuery);
        }

        public DelegateAccessTokenDestroyOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public DelegateAccessTokenDestroyOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DelegateAccessTokenDestroyOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenDestroyUserErrorQueryBuilder> build)
        {
            var query = new Query<DelegateAccessTokenDestroyUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DelegateAccessTokenDestroyUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessTokenDestroyUserError>(query);
            return this;
        }
    }
}