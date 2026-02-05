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

        public UrlRedirectImportSubmitOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectImportSubmitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}