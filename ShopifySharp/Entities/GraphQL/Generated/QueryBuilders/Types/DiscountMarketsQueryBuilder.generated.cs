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
    public sealed class DiscountMarketsQueryBuilder : FieldsQueryBuilderBase<DiscountMarkets, DiscountMarketsQueryBuilder>
    {
        protected override DiscountMarketsQueryBuilder Self => this;

        public DiscountMarketsQueryBuilder() : this("discountMarkets")
        {
        }

        public DiscountMarketsQueryBuilder(string name) : base(new Query<DiscountMarkets>(name))
        {
        }

        public DiscountMarketsQueryBuilder(IQuery<DiscountMarkets> query) : base(query)
        {
        }

        public DiscountMarketsQueryBuilder Markets(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketConnectionQueryBuilder> build)
        {
            var query = new Query<MarketConnection>("markets");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConnection>(query);
            return this;
        }

        public DiscountMarketsQueryBuilder MarketsCount()
        {
            base.InnerQuery.AddField("marketsCount");
            return this;
        }
    }
}