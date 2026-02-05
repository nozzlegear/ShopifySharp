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
    public sealed class WebPixelDeleteOperationQueryBuilder : FieldsQueryBuilderBase<WebPixelDeletePayload, WebPixelDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPixelDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPixelDeleteArgumentsBuilder Arguments { get; }
        protected override WebPixelDeleteOperationQueryBuilder Self => this;

        public WebPixelDeleteOperationQueryBuilder() : this("webPixelDelete")
        {
        }

        public WebPixelDeleteOperationQueryBuilder(string name) : base(new Query<WebPixelDeletePayload>(name))
        {
            Arguments = new WebPixelDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelDeleteOperationQueryBuilder(IQuery<WebPixelDeletePayload> query) : base(query)
        {
            Arguments = new WebPixelDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelDeleteOperationQueryBuilder DeletedWebPixelId()
        {
            base.InnerQuery.AddField("deletedWebPixelId");
            return this;
        }

        public WebPixelDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }
    }
}