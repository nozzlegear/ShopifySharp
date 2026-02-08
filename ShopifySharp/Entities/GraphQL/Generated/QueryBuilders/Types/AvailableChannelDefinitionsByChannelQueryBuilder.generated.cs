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
    public sealed class AvailableChannelDefinitionsByChannelQueryBuilder : FieldsQueryBuilderBase<AvailableChannelDefinitionsByChannel, AvailableChannelDefinitionsByChannelQueryBuilder>
    {
        protected override AvailableChannelDefinitionsByChannelQueryBuilder Self => this;

        public AvailableChannelDefinitionsByChannelQueryBuilder() : this("availableChannelDefinitionsByChannel")
        {
        }

        public AvailableChannelDefinitionsByChannelQueryBuilder(string name) : base(new Query<AvailableChannelDefinitionsByChannel>(name))
        {
        }

        public AvailableChannelDefinitionsByChannelQueryBuilder(IQuery<AvailableChannelDefinitionsByChannel> query) : base(query)
        {
        }

        public AvailableChannelDefinitionsByChannelQueryBuilder ChannelDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelDefinitionQueryBuilder> build)
        {
            var query = new Query<ChannelDefinition>("channelDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelDefinition>(query);
            return this;
        }

        public AvailableChannelDefinitionsByChannelQueryBuilder ChannelName()
        {
            base.InnerQuery.AddField("channelName");
            return this;
        }
    }
}