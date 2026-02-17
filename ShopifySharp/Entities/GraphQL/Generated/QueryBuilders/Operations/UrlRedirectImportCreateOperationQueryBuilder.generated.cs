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

        public UrlRedirectImportCreateOperationQueryBuilder UrlRedirectImport(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImport>("urlRedirectImport");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImport>(query);
            return this;
        }

        public UrlRedirectImportCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}