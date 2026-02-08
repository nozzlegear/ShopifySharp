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
    public sealed class BulkOperationCancelPayloadQueryBuilder : FieldsQueryBuilderBase<BulkOperationCancelPayload, BulkOperationCancelPayloadQueryBuilder>
    {
        protected override BulkOperationCancelPayloadQueryBuilder Self => this;

        public BulkOperationCancelPayloadQueryBuilder() : this("bulkOperationCancelPayload")
        {
        }

        public BulkOperationCancelPayloadQueryBuilder(string name) : base(new Query<BulkOperationCancelPayload>(name))
        {
        }

        public BulkOperationCancelPayloadQueryBuilder(IQuery<BulkOperationCancelPayload> query) : base(query)
        {
        }

        public BulkOperationCancelPayloadQueryBuilder BulkOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("bulkOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationCancelPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}