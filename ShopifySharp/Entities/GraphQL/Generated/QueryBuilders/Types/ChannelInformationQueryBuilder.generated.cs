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
    public sealed class ChannelInformationQueryBuilder : FieldsQueryBuilderBase<ChannelInformation, ChannelInformationQueryBuilder>
    {
        protected override ChannelInformationQueryBuilder Self => this;

        public ChannelInformationQueryBuilder() : this("channelInformation")
        {
        }

        public ChannelInformationQueryBuilder(string name) : base(new Query<ChannelInformation>(name))
        {
        }

        public ChannelInformationQueryBuilder(IQuery<ChannelInformation> query) : base(query)
        {
        }

        public ChannelInformationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public ChannelInformationQueryBuilder ChannelDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelDefinitionQueryBuilder> build)
        {
            var query = new Query<ChannelDefinition>("channelDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelDefinition>(query);
            return this;
        }

        public ChannelInformationQueryBuilder ChannelId()
        {
            base.InnerQuery.AddField("channelId");
            return this;
        }

        public ChannelInformationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ChannelInformationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}