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
    public sealed class PubSubServerPixelUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PubSubServerPixelUpdatePayload, PubSubServerPixelUpdatePayloadQueryBuilder>
    {
        protected override PubSubServerPixelUpdatePayloadQueryBuilder Self => this;

        public PubSubServerPixelUpdatePayloadQueryBuilder() : this("pubSubServerPixelUpdatePayload")
        {
        }

        public PubSubServerPixelUpdatePayloadQueryBuilder(string name) : base(new Query<PubSubServerPixelUpdatePayload>(name))
        {
        }

        public PubSubServerPixelUpdatePayloadQueryBuilder(IQuery<PubSubServerPixelUpdatePayload> query) : base(query)
        {
        }

        public PubSubServerPixelUpdatePayloadQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public PubSubServerPixelUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}