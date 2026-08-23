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
    public sealed class ChannelsConditionQueryBuilder : FieldsQueryBuilderBase<ChannelsCondition, ChannelsConditionQueryBuilder>
    {
        protected override ChannelsConditionQueryBuilder Self => this;

        public ChannelsConditionQueryBuilder() : this("channelsCondition")
        {
        }

        public ChannelsConditionQueryBuilder(string name) : base(new Query<ChannelsCondition>(name))
        {
        }

        public ChannelsConditionQueryBuilder(IQuery<ChannelsCondition> query) : base(query)
        {
        }

        public ChannelsConditionQueryBuilder ApplicationLevel()
        {
            base.InnerQuery.AddField("applicationLevel");
            return this;
        }

        public ChannelsConditionQueryBuilder Channels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("channels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public ChannelsConditionQueryBuilder ChannelsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("channelsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }
    }
}