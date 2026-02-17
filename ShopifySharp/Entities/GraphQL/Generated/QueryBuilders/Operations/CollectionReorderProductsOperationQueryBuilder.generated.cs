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
    public sealed class CollectionReorderProductsOperationQueryBuilder : FieldsQueryBuilderBase<CollectionReorderProductsPayload, CollectionReorderProductsOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionReorderProductsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionReorderProductsArgumentsBuilder Arguments { get; }
        protected override CollectionReorderProductsOperationQueryBuilder Self => this;

        public CollectionReorderProductsOperationQueryBuilder() : this("collectionReorderProducts")
        {
        }

        public CollectionReorderProductsOperationQueryBuilder(string name) : base(new Query<CollectionReorderProductsPayload>(name))
        {
            Arguments = new CollectionReorderProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionReorderProductsOperationQueryBuilder(IQuery<CollectionReorderProductsPayload> query) : base(query)
        {
            Arguments = new CollectionReorderProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionReorderProductsOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionReorderProductsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionReorderProductsUserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionReorderProductsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionReorderProductsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionReorderProductsUserError>(query);
            return this;
        }
    }
}