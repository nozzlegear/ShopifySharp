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

        public UrlRedirectDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}