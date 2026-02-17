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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class BulkOperationUserErrorQueryBuilder : FieldsQueryBuilderBase<BulkOperationUserError, BulkOperationUserErrorQueryBuilder>
    {
        protected override BulkOperationUserErrorQueryBuilder Self => this;

        public BulkOperationUserErrorQueryBuilder() : this("bulkOperationUserError")
        {
        }

        public BulkOperationUserErrorQueryBuilder(string name) : base(new Query<BulkOperationUserError>(name))
        {
        }

        public BulkOperationUserErrorQueryBuilder(IQuery<BulkOperationUserError> query) : base(query)
        {
        }

        public BulkOperationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BulkOperationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BulkOperationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}