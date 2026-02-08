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
    public sealed class MarketWebPresenceRootUrlQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceRootUrl, MarketWebPresenceRootUrlQueryBuilder>
    {
        protected override MarketWebPresenceRootUrlQueryBuilder Self => this;

        public MarketWebPresenceRootUrlQueryBuilder() : this("marketWebPresenceRootUrl")
        {
        }

        public MarketWebPresenceRootUrlQueryBuilder(string name) : base(new Query<MarketWebPresenceRootUrl>(name))
        {
        }

        public MarketWebPresenceRootUrlQueryBuilder(IQuery<MarketWebPresenceRootUrl> query) : base(query)
        {
        }

        public MarketWebPresenceRootUrlQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public MarketWebPresenceRootUrlQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}