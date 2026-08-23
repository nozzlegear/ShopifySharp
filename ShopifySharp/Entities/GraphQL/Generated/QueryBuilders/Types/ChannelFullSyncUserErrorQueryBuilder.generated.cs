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
    public sealed class ChannelFullSyncUserErrorQueryBuilder : FieldsQueryBuilderBase<ChannelFullSyncUserError, ChannelFullSyncUserErrorQueryBuilder>
    {
        protected override ChannelFullSyncUserErrorQueryBuilder Self => this;

        public ChannelFullSyncUserErrorQueryBuilder() : this("channelFullSyncUserError")
        {
        }

        public ChannelFullSyncUserErrorQueryBuilder(string name) : base(new Query<ChannelFullSyncUserError>(name))
        {
        }

        public ChannelFullSyncUserErrorQueryBuilder(IQuery<ChannelFullSyncUserError> query) : base(query)
        {
        }

        public ChannelFullSyncUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ChannelFullSyncUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ChannelFullSyncUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}