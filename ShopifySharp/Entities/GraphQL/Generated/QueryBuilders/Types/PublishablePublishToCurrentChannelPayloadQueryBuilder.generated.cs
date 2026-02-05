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
    public sealed class PublishablePublishToCurrentChannelPayloadQueryBuilder : FieldsQueryBuilderBase<PublishablePublishToCurrentChannelPayload, PublishablePublishToCurrentChannelPayloadQueryBuilder>
    {
        protected override PublishablePublishToCurrentChannelPayloadQueryBuilder Self => this;

        public PublishablePublishToCurrentChannelPayloadQueryBuilder() : this("publishablePublishToCurrentChannelPayload")
        {
        }

        public PublishablePublishToCurrentChannelPayloadQueryBuilder(string name) : base(new Query<PublishablePublishToCurrentChannelPayload>(name))
        {
        }

        public PublishablePublishToCurrentChannelPayloadQueryBuilder(IQuery<PublishablePublishToCurrentChannelPayload> query) : base(query)
        {
        }

        public PublishablePublishToCurrentChannelPayloadQueryBuilder Publishable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder> build)
        {
            var query = new Query<IPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IPublishable>(query);
            return this;
        }

        public PublishablePublishToCurrentChannelPayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public PublishablePublishToCurrentChannelPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}