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
    public sealed class ChannelCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ChannelCreateUserError, ChannelCreateUserErrorQueryBuilder>
    {
        protected override ChannelCreateUserErrorQueryBuilder Self => this;

        public ChannelCreateUserErrorQueryBuilder() : this("channelCreateUserError")
        {
        }

        public ChannelCreateUserErrorQueryBuilder(string name) : base(new Query<ChannelCreateUserError>(name))
        {
        }

        public ChannelCreateUserErrorQueryBuilder(IQuery<ChannelCreateUserError> query) : base(query)
        {
        }

        public ChannelCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ChannelCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ChannelCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}