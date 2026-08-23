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
    public sealed class ChannelDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ChannelDeleteUserError, ChannelDeleteUserErrorQueryBuilder>
    {
        protected override ChannelDeleteUserErrorQueryBuilder Self => this;

        public ChannelDeleteUserErrorQueryBuilder() : this("channelDeleteUserError")
        {
        }

        public ChannelDeleteUserErrorQueryBuilder(string name) : base(new Query<ChannelDeleteUserError>(name))
        {
        }

        public ChannelDeleteUserErrorQueryBuilder(IQuery<ChannelDeleteUserError> query) : base(query)
        {
        }

        public ChannelDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ChannelDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ChannelDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}