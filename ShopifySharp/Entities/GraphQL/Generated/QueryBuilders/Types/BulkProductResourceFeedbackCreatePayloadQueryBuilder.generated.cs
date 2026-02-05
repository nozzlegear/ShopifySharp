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
    public sealed class BulkProductResourceFeedbackCreatePayloadQueryBuilder : FieldsQueryBuilderBase<BulkProductResourceFeedbackCreatePayload, BulkProductResourceFeedbackCreatePayloadQueryBuilder>
    {
        protected override BulkProductResourceFeedbackCreatePayloadQueryBuilder Self => this;

        public BulkProductResourceFeedbackCreatePayloadQueryBuilder() : this("bulkProductResourceFeedbackCreatePayload")
        {
        }

        public BulkProductResourceFeedbackCreatePayloadQueryBuilder(string name) : base(new Query<BulkProductResourceFeedbackCreatePayload>(name))
        {
        }

        public BulkProductResourceFeedbackCreatePayloadQueryBuilder(IQuery<BulkProductResourceFeedbackCreatePayload> query) : base(query)
        {
        }

        public BulkProductResourceFeedbackCreatePayloadQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ProductResourceFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductResourceFeedback>(query);
            return this;
        }

        public BulkProductResourceFeedbackCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkProductResourceFeedbackCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<BulkProductResourceFeedbackCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkProductResourceFeedbackCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkProductResourceFeedbackCreateUserError>(query);
            return this;
        }
    }
}