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
    public sealed class ChannelUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ChannelUpdateUserError, ChannelUpdateUserErrorQueryBuilder>
    {
        protected override ChannelUpdateUserErrorQueryBuilder Self => this;

        public ChannelUpdateUserErrorQueryBuilder() : this("channelUpdateUserError")
        {
        }

        public ChannelUpdateUserErrorQueryBuilder(string name) : base(new Query<ChannelUpdateUserError>(name))
        {
        }

        public ChannelUpdateUserErrorQueryBuilder(IQuery<ChannelUpdateUserError> query) : base(query)
        {
        }

        public ChannelUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ChannelUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ChannelUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}