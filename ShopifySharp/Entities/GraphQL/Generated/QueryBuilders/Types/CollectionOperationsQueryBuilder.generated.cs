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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CollectionOperationsQueryBuilder : FieldsQueryBuilderBase<CollectionOperations, CollectionOperationsQueryBuilder>
    {
        protected override CollectionOperationsQueryBuilder Self => this;

        public CollectionOperationsQueryBuilder() : this("collectionOperations")
        {
        }

        public CollectionOperationsQueryBuilder(string name) : base(new Query<CollectionOperations>(name))
        {
        }

        public CollectionOperationsQueryBuilder(IQuery<CollectionOperations> query) : base(query)
        {
        }

        public CollectionOperationsQueryBuilder Duplicate(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<CollectionDuplicateOperation>("duplicate");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionDuplicateOperation>(query);
            return this;
        }
    }
}