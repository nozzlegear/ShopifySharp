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
    public sealed class WebPixelCreateOperationQueryBuilder : FieldsQueryBuilderBase<WebPixelCreatePayload, WebPixelCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPixelCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPixelCreateArgumentsBuilder Arguments { get; }
        protected override WebPixelCreateOperationQueryBuilder Self => this;

        public WebPixelCreateOperationQueryBuilder() : this("webPixelCreate")
        {
        }

        public WebPixelCreateOperationQueryBuilder(string name) : base(new Query<WebPixelCreatePayload>(name))
        {
            Arguments = new WebPixelCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelCreateOperationQueryBuilder(IQuery<WebPixelCreatePayload> query) : base(query)
        {
            Arguments = new WebPixelCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }

        public WebPixelCreateOperationQueryBuilder WebPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("webPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebPixel>(query);
            return this;
        }
    }
}