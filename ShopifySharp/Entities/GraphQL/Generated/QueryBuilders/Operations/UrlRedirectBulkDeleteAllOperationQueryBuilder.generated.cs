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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class UrlRedirectBulkDeleteAllOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteAllPayload, UrlRedirectBulkDeleteAllOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectBulkDeleteAllPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        protected override UrlRedirectBulkDeleteAllOperationQueryBuilder Self => this;

        public UrlRedirectBulkDeleteAllOperationQueryBuilder() : this("urlRedirectBulkDeleteAll")
        {
        }

        public UrlRedirectBulkDeleteAllOperationQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteAllPayload>(name))
        {
        }

        public UrlRedirectBulkDeleteAllOperationQueryBuilder(IQuery<UrlRedirectBulkDeleteAllPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteAllOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteAllOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}