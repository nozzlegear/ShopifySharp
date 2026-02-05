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
    public sealed class UrlRedirectBulkDeleteBySearchOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySearchPayload, UrlRedirectBulkDeleteBySearchOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectBulkDeleteBySearchPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectBulkDeleteBySearchArgumentsBuilder Arguments { get; }
        protected override UrlRedirectBulkDeleteBySearchOperationQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySearchOperationQueryBuilder() : this("urlRedirectBulkDeleteBySearch")
        {
        }

        public UrlRedirectBulkDeleteBySearchOperationQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySearchPayload>(name))
        {
            Arguments = new UrlRedirectBulkDeleteBySearchArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteBySearchOperationQueryBuilder(IQuery<UrlRedirectBulkDeleteBySearchPayload> query) : base(query)
        {
            Arguments = new UrlRedirectBulkDeleteBySearchArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectBulkDeleteBySearchOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteBySearchOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteBySearchUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteBySearchUserError>(query);
            return this;
        }
    }
}