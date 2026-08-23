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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ChannelDefinitionQueryBuilder : FieldsQueryBuilderBase<ChannelDefinition, ChannelDefinitionQueryBuilder>
    {
        protected override ChannelDefinitionQueryBuilder Self => this;

        public ChannelDefinitionQueryBuilder() : this("channelDefinition")
        {
        }

        public ChannelDefinitionQueryBuilder(string name) : base(new Query<ChannelDefinition>(name))
        {
        }

        public ChannelDefinitionQueryBuilder(IQuery<ChannelDefinition> query) : base(query)
        {
        }

        [Obsolete("Use [`OrderAttributionDefinition.displayName`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.displayName) instead.")]
        public ChannelDefinitionQueryBuilder ChannelName()
        {
            base.InnerQuery.AddField("channelName");
            return this;
        }

        [Obsolete("Use [`OrderAttributionDefinition.handle`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.handle) instead.")]
        public ChannelDefinitionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        [Obsolete("Use [`OrderAttributionDefinition.id`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.id) instead.")]
        public ChannelDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Use [`OrderAttributionDefinition.handle`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.handle) instead.")]
        public ChannelDefinitionQueryBuilder IsMarketplace()
        {
            base.InnerQuery.AddField("isMarketplace");
            return this;
        }

        [Obsolete("Use [`OrderAttributionDefinition.displayName`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.displayName) instead.")]
        public ChannelDefinitionQueryBuilder SubChannelName()
        {
            base.InnerQuery.AddField("subChannelName");
            return this;
        }

        [Obsolete("Use [`OrderAttributionDefinition.icon`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.icon) instead.")]
        public ChannelDefinitionQueryBuilder SvgIcon()
        {
            base.InnerQuery.AddField("svgIcon");
            return this;
        }
    }
}