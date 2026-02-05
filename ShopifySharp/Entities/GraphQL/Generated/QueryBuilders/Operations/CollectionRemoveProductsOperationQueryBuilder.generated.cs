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
    public sealed class CollectionRemoveProductsOperationQueryBuilder : FieldsQueryBuilderBase<CollectionRemoveProductsPayload, CollectionRemoveProductsOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionRemoveProductsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionRemoveProductsArgumentsBuilder Arguments { get; }
        protected override CollectionRemoveProductsOperationQueryBuilder Self => this;

        public CollectionRemoveProductsOperationQueryBuilder() : this("collectionRemoveProducts")
        {
        }

        public CollectionRemoveProductsOperationQueryBuilder(string name) : base(new Query<CollectionRemoveProductsPayload>(name))
        {
            Arguments = new CollectionRemoveProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionRemoveProductsOperationQueryBuilder(IQuery<CollectionRemoveProductsPayload> query) : base(query)
        {
            Arguments = new CollectionRemoveProductsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionRemoveProductsOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionRemoveProductsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}