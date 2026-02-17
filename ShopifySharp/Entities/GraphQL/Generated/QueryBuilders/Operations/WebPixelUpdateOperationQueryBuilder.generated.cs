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
    public sealed class WebPixelUpdateOperationQueryBuilder : FieldsQueryBuilderBase<WebPixelUpdatePayload, WebPixelUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPixelUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPixelUpdateArgumentsBuilder Arguments { get; }
        protected override WebPixelUpdateOperationQueryBuilder Self => this;

        public WebPixelUpdateOperationQueryBuilder() : this("webPixelUpdate")
        {
        }

        public WebPixelUpdateOperationQueryBuilder(string name) : base(new Query<WebPixelUpdatePayload>(name))
        {
            Arguments = new WebPixelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelUpdateOperationQueryBuilder(IQuery<WebPixelUpdatePayload> query) : base(query)
        {
            Arguments = new WebPixelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }

        public WebPixelUpdateOperationQueryBuilder WebPixel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("webPixel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebPixel>(query);
            return this;
        }
    }
}