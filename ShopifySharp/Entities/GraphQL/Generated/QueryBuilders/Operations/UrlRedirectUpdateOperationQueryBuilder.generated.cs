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
    public sealed class UrlRedirectUpdateOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectUpdatePayload, UrlRedirectUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectUpdateArgumentsBuilder Arguments { get; }
        protected override UrlRedirectUpdateOperationQueryBuilder Self => this;

        public UrlRedirectUpdateOperationQueryBuilder() : this("urlRedirectUpdate")
        {
        }

        public UrlRedirectUpdateOperationQueryBuilder(string name) : base(new Query<UrlRedirectUpdatePayload>(name))
        {
            Arguments = new UrlRedirectUpdateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectUpdateOperationQueryBuilder(IQuery<UrlRedirectUpdatePayload> query) : base(query)
        {
            Arguments = new UrlRedirectUpdateArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectUpdateOperationQueryBuilder UrlRedirect(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("urlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}