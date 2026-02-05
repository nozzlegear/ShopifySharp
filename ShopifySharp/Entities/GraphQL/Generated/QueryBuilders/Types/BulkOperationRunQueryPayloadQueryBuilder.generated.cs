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
    public sealed class BulkOperationRunQueryPayloadQueryBuilder : FieldsQueryBuilderBase<BulkOperationRunQueryPayload, BulkOperationRunQueryPayloadQueryBuilder>
    {
        protected override BulkOperationRunQueryPayloadQueryBuilder Self => this;

        public BulkOperationRunQueryPayloadQueryBuilder() : this("bulkOperationRunQueryPayload")
        {
        }

        public BulkOperationRunQueryPayloadQueryBuilder(string name) : base(new Query<BulkOperationRunQueryPayload>(name))
        {
        }

        public BulkOperationRunQueryPayloadQueryBuilder(IQuery<BulkOperationRunQueryPayload> query) : base(query)
        {
        }

        public BulkOperationRunQueryPayloadQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationRunQueryPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkOperationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationUserError>(query);
            return this;
        }
    }
}