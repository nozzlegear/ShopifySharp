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
    public sealed class AppleApplicationQueryBuilder : FieldsQueryBuilderBase<AppleApplication, AppleApplicationQueryBuilder>
    {
        protected override AppleApplicationQueryBuilder Self => this;

        public AppleApplicationQueryBuilder() : this("appleApplication")
        {
        }

        public AppleApplicationQueryBuilder(string name) : base(new Query<AppleApplication>(name))
        {
        }

        public AppleApplicationQueryBuilder(IQuery<AppleApplication> query) : base(query)
        {
        }

        public AppleApplicationQueryBuilder AppClipApplicationId()
        {
            base.InnerQuery.AddField("appClipApplicationId");
            return this;
        }

        public AppleApplicationQueryBuilder AppClipsEnabled()
        {
            base.InnerQuery.AddField("appClipsEnabled");
            return this;
        }

        public AppleApplicationQueryBuilder AppId()
        {
            base.InnerQuery.AddField("appId");
            return this;
        }

        public AppleApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppleApplicationQueryBuilder SharedWebCredentialsEnabled()
        {
            base.InnerQuery.AddField("sharedWebCredentialsEnabled");
            return this;
        }

        public AppleApplicationQueryBuilder UniversalLinksEnabled()
        {
            base.InnerQuery.AddField("universalLinksEnabled");
            return this;
        }
    }
}