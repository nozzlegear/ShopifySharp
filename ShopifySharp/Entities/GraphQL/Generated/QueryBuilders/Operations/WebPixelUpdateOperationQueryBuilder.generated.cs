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

        public WebPixelUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }

        public WebPixelUpdateOperationQueryBuilder WebPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder> build)
        {
            var query = new Query<WebPixel>("webPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebPixel>(query);
            return this;
        }
    }
}