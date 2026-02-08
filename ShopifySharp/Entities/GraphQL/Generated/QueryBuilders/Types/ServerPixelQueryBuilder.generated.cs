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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ServerPixelQueryBuilder : FieldsQueryBuilderBase<ServerPixel, ServerPixelQueryBuilder>
    {
        protected override ServerPixelQueryBuilder Self => this;

        public ServerPixelQueryBuilder() : this("serverPixel")
        {
        }

        public ServerPixelQueryBuilder(string name) : base(new Query<ServerPixel>(name))
        {
        }

        public ServerPixelQueryBuilder(IQuery<ServerPixel> query) : base(query)
        {
        }

        public ServerPixelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ServerPixelQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ServerPixelQueryBuilder WebhookEndpointAddress()
        {
            base.InnerQuery.AddField("webhookEndpointAddress");
            return this;
        }
    }
}