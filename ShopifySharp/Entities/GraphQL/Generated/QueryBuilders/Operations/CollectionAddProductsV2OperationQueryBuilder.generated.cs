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
    public sealed class CollectionAddProductsV2OperationQueryBuilder : FieldsQueryBuilderBase<CollectionAddProductsV2Payload, CollectionAddProductsV2OperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionAddProductsV2Payload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionAddProductsV2ArgumentsBuilder Arguments { get; }
        protected override CollectionAddProductsV2OperationQueryBuilder Self => this;

        public CollectionAddProductsV2OperationQueryBuilder() : this("collectionAddProductsV2")
        {
        }

        public CollectionAddProductsV2OperationQueryBuilder(string name) : base(new Query<CollectionAddProductsV2Payload>(name))
        {
            Arguments = new CollectionAddProductsV2ArgumentsBuilder(base.InnerQuery);
        }

        public CollectionAddProductsV2OperationQueryBuilder(IQuery<CollectionAddProductsV2Payload> query) : base(query)
        {
            Arguments = new CollectionAddProductsV2ArgumentsBuilder(base.InnerQuery);
        }

        public CollectionAddProductsV2OperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionAddProductsV2OperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionAddProductsV2UserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionAddProductsV2UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionAddProductsV2UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionAddProductsV2UserError>(query);
            return this;
        }
    }
}