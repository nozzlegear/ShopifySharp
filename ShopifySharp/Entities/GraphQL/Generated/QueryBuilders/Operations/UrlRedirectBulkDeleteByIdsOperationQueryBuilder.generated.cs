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
    public sealed class UrlRedirectBulkDeleteByIdsOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteByIdsPayload, UrlRedirectBulkDeleteByIdsOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectBulkDeleteByIdsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectBulkDeleteByIdsArgumentsBuilder Arguments { get; }
        protected override UrlRedirectBulkDeleteByIdsOperationQueryBuilder Self => this;

        public UrlRedirectBulkDeleteByIdsOperationQueryBuilder() : this("urlRedirectBulkDeleteByIds")
        {
        }

        public UrlRedirectBulkDeleteByIdsOperationQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteByIdsPayload>(name))
        {
            Arguments = new UrlRedirectBulkDeleteByIdsArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteByIdsOperationQueryBuilder(IQuery<UrlRedirectBulkDeleteByIdsPayload> query) : base(query)
        {
            Arguments = new UrlRedirectBulkDeleteByIdsArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteByIdsOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteByIdsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteByIdsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteByIdsUserError>(query);
            return this;
        }
    }
}