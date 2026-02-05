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
    public sealed class UrlRedirectDeleteOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectDeletePayload, UrlRedirectDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public UrlRedirectDeleteArgumentsBuilder Arguments { get; }
        protected override UrlRedirectDeleteOperationQueryBuilder Self => this;

        public UrlRedirectDeleteOperationQueryBuilder() : this("urlRedirectDelete")
        {
        }

        public UrlRedirectDeleteOperationQueryBuilder(string name) : base(new Query<UrlRedirectDeletePayload>(name))
        {
            Arguments = new UrlRedirectDeleteArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectDeleteOperationQueryBuilder(IQuery<UrlRedirectDeletePayload> query) : base(query)
        {
            Arguments = new UrlRedirectDeleteArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectDeleteOperationQueryBuilder DeletedUrlRedirectId()
        {
            base.InnerQuery.AddField("deletedUrlRedirectId");
            return this;
        }

        public UrlRedirectDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}