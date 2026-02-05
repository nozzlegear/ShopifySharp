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
    public sealed class CollectionDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionDuplicateOperation, CollectionDuplicateOperationQueryBuilder>
    {
        protected override CollectionDuplicateOperationQueryBuilder Self => this;

        public CollectionDuplicateOperationQueryBuilder() : this("collectionDuplicateOperation")
        {
        }

        public CollectionDuplicateOperationQueryBuilder(string name) : base(new Query<CollectionDuplicateOperation>(name))
        {
        }

        public CollectionDuplicateOperationQueryBuilder(IQuery<CollectionDuplicateOperation> query) : base(query)
        {
        }

        public CollectionDuplicateOperationQueryBuilder CollectionRole()
        {
            base.InnerQuery.AddField("collectionRole");
            return this;
        }

        public CollectionDuplicateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }
    }
}