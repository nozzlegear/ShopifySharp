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
    public sealed class MarketLocalizableContentQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableContent, MarketLocalizableContentQueryBuilder>
    {
        protected override MarketLocalizableContentQueryBuilder Self => this;

        public MarketLocalizableContentQueryBuilder() : this("marketLocalizableContent")
        {
        }

        public MarketLocalizableContentQueryBuilder(string name) : base(new Query<MarketLocalizableContent>(name))
        {
        }

        public MarketLocalizableContentQueryBuilder(IQuery<MarketLocalizableContent> query) : base(query)
        {
        }

        public MarketLocalizableContentQueryBuilder Digest()
        {
            base.InnerQuery.AddField("digest");
            return this;
        }

        public MarketLocalizableContentQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MarketLocalizableContentQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}