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

        public ServerPixelDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}