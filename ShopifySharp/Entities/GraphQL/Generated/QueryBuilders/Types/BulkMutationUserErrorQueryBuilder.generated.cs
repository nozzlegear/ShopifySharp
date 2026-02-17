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
    public sealed class BulkMutationUserErrorQueryBuilder : FieldsQueryBuilderBase<BulkMutationUserError, BulkMutationUserErrorQueryBuilder>
    {
        protected override BulkMutationUserErrorQueryBuilder Self => this;

        public BulkMutationUserErrorQueryBuilder() : this("bulkMutationUserError")
        {
        }

        public BulkMutationUserErrorQueryBuilder(string name) : base(new Query<BulkMutationUserError>(name))
        {
        }

        public BulkMutationUserErrorQueryBuilder(IQuery<BulkMutationUserError> query) : base(query)
        {
        }

        public BulkMutationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BulkMutationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BulkMutationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}