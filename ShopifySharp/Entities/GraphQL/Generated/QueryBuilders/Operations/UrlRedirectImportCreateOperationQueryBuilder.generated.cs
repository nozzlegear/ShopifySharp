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
    public sealed class UrlRedirectImportCreateOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportCreatePayload, UrlRedirectImportCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectImportCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectImportCreateArgumentsBuilder Arguments { get; }
        protected override UrlRedirectImportCreateOperationQueryBuilder Self => this;

        public UrlRedirectImportCreateOperationQueryBuilder() : this("urlRedirectImportCreate")
        {
        }

        public UrlRedirectImportCreateOperationQueryBuilder(string name) : base(new Query<UrlRedirectImportCreatePayload>(name))
        {
            Arguments = new UrlRedirectImportCreateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportCreateOperationQueryBuilder(IQuery<UrlRedirectImportCreatePayload> query) : base(query)
        {
            Arguments = new UrlRedirectImportCreateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportCreateOperationQueryBuilder UrlRedirectImport(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImport>("urlRedirectImport");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImport>(query);
            return this;
        }

        public UrlRedirectImportCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}