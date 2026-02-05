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
    public sealed class MarketLocalizationQueryBuilder : FieldsQueryBuilderBase<MarketLocalization, MarketLocalizationQueryBuilder>
    {
        protected override MarketLocalizationQueryBuilder Self => this;

        public MarketLocalizationQueryBuilder() : this("marketLocalization")
        {
        }

        public MarketLocalizationQueryBuilder(string name) : base(new Query<MarketLocalization>(name))
        {
        }

        public MarketLocalizationQueryBuilder(IQuery<MarketLocalization> query) : base(query)
        {
        }

        public MarketLocalizationQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MarketLocalizationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketLocalizationQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public MarketLocalizationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MarketLocalizationQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}