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
    public sealed class ServerPixelOperationQueryBuilder : FieldsQueryBuilderBase<ServerPixel, ServerPixelOperationQueryBuilder>, IGraphOperationQueryBuilder<ServerPixel>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override ServerPixelOperationQueryBuilder Self => this;

        public ServerPixelOperationQueryBuilder() : this("serverPixel")
        {
        }

        public ServerPixelOperationQueryBuilder(string name) : base(new Query<ServerPixel>(name))
        {
        }

        public ServerPixelOperationQueryBuilder(IQuery<ServerPixel> query) : base(query)
        {
        }

        public ServerPixelOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ServerPixelOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ServerPixelOperationQueryBuilder WebhookEndpointAddress()
        {
            base.InnerQuery.AddField("webhookEndpointAddress");
            return this;
        }
    }
}