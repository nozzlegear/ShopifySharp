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
    public sealed class ServerPixelCreateOperationQueryBuilder : FieldsQueryBuilderBase<ServerPixelCreatePayload, ServerPixelCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ServerPixelCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        protected override ServerPixelCreateOperationQueryBuilder Self => this;

        public ServerPixelCreateOperationQueryBuilder() : this("serverPixelCreate")
        {
        }

        public ServerPixelCreateOperationQueryBuilder(string name) : base(new Query<ServerPixelCreatePayload>(name))
        {
        }

        public ServerPixelCreateOperationQueryBuilder(IQuery<ServerPixelCreatePayload> query) : base(query)
        {
        }

        public ServerPixelCreateOperationQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public ServerPixelCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}