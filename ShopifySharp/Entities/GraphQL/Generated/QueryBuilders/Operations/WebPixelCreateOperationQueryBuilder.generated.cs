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

        public WebPixelCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }

        public WebPixelCreateOperationQueryBuilder WebPixel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("webPixel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebPixel>(query);
            return this;
        }
    }
}