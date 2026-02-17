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

        public ChannelDefinitionQueryBuilder ChannelName()
        {
            base.InnerQuery.AddField("channelName");
            return this;
        }

        public ChannelDefinitionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ChannelDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ChannelDefinitionQueryBuilder IsMarketplace()
        {
            base.InnerQuery.AddField("isMarketplace");
            return this;
        }

        public ChannelDefinitionQueryBuilder SubChannelName()
        {
            base.InnerQuery.AddField("subChannelName");
            return this;
        }

        [Obsolete("Use App.icon instead")]
        public ChannelDefinitionQueryBuilder SvgIcon()
        {
            base.InnerQuery.AddField("svgIcon");
            return this;
        }
    }
}