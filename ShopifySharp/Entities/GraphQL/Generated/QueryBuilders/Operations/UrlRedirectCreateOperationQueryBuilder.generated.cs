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
    public sealed class UrlRedirectCreateOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectCreatePayload, UrlRedirectCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectCreateArgumentsBuilder Arguments { get; }
        protected override UrlRedirectCreateOperationQueryBuilder Self => this;

        public UrlRedirectCreateOperationQueryBuilder() : this("urlRedirectCreate")
        {
        }

        public UrlRedirectCreateOperationQueryBuilder(string name) : base(new Query<UrlRedirectCreatePayload>(name))
        {
            Arguments = new UrlRedirectCreateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectCreateOperationQueryBuilder(IQuery<UrlRedirectCreatePayload> query) : base(query)
        {
            Arguments = new UrlRedirectCreateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectCreateOperationQueryBuilder UrlRedirect(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("urlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}