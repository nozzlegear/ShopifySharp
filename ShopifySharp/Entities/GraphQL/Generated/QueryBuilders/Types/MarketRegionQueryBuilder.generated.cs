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
    public sealed class MarketRegionQueryBuilder : FieldsQueryBuilderBase<IMarketRegion, MarketRegionQueryBuilder>
    {
        protected override MarketRegionQueryBuilder Self => this;

        public MarketRegionQueryBuilder() : this("marketRegion")
        {
        }

        public MarketRegionQueryBuilder(string name) : base(new Query<IMarketRegion>(name))
        {
        }

        public MarketRegionQueryBuilder(IQuery<IMarketRegion> query) : base(query)
        {
        }

        public MarketRegionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketRegionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}