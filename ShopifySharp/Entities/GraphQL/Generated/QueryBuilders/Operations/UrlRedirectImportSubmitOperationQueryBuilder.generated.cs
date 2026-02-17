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
    public sealed class UrlRedirectImportSubmitOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportSubmitPayload, UrlRedirectImportSubmitOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectImportSubmitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectImportSubmitArgumentsBuilder Arguments { get; }
        protected override UrlRedirectImportSubmitOperationQueryBuilder Self => this;

        public UrlRedirectImportSubmitOperationQueryBuilder() : this("urlRedirectImportSubmit")
        {
        }

        public UrlRedirectImportSubmitOperationQueryBuilder(string name) : base(new Query<UrlRedirectImportSubmitPayload>(name))
        {
            Arguments = new UrlRedirectImportSubmitArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportSubmitOperationQueryBuilder(IQuery<UrlRedirectImportSubmitPayload> query) : base(query)
        {
            Arguments = new UrlRedirectImportSubmitArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportSubmitOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectImportSubmitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}