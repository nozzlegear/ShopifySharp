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
    public sealed class UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySavedSearchPayload, UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectBulkDeleteBySavedSearchPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder Arguments { get; }
        protected override UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder() : this("urlRedirectBulkDeleteBySavedSearch")
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySavedSearchPayload>(name))
        {
            Arguments = new UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder(IQuery<UrlRedirectBulkDeleteBySavedSearchPayload> query) : base(query)
        {
            Arguments = new UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteBySavedSearchOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteBySavedSearchUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteBySavedSearchUserError>(query);
            return this;
        }
    }
}