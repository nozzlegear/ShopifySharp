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
    public sealed class BulkProductResourceFeedbackCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<BulkProductResourceFeedbackCreateUserError, BulkProductResourceFeedbackCreateUserErrorQueryBuilder>
    {
        protected override BulkProductResourceFeedbackCreateUserErrorQueryBuilder Self => this;

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder() : this("bulkProductResourceFeedbackCreateUserError")
        {
        }

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder(string name) : base(new Query<BulkProductResourceFeedbackCreateUserError>(name))
        {
        }

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder(IQuery<BulkProductResourceFeedbackCreateUserError> query) : base(query)
        {
        }

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BulkProductResourceFeedbackCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}