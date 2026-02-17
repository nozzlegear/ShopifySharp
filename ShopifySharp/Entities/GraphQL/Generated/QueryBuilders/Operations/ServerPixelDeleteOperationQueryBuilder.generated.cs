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
    public sealed class ServerPixelDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ServerPixelDeletePayload, ServerPixelDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ServerPixelDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        protected override ServerPixelDeleteOperationQueryBuilder Self => this;

        public ServerPixelDeleteOperationQueryBuilder() : this("serverPixelDelete")
        {
        }

        public ServerPixelDeleteOperationQueryBuilder(string name) : base(new Query<ServerPixelDeletePayload>(name))
        {
        }

        public ServerPixelDeleteOperationQueryBuilder(IQuery<ServerPixelDeletePayload> query) : base(query)
        {
        }

        public ServerPixelDeleteOperationQueryBuilder DeletedServerPixelId()
        {
            base.InnerQuery.AddField("deletedServerPixelId");
            return this;
        }

        public ServerPixelDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}