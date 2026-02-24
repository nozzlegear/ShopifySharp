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
    public sealed class MarketLocalizableResourceMarketLocalizationsQueryBuilder : FieldsQueryBuilderBase<MarketLocalization, MarketLocalizableResourceMarketLocalizationsQueryBuilder>, IHasArguments<MarketLocalizableResourceMarketLocalizationsArgumentsBuilder>
    {
        public MarketLocalizableResourceMarketLocalizationsArgumentsBuilder Arguments { get; }
        protected override MarketLocalizableResourceMarketLocalizationsQueryBuilder Self => this;

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder(string name) : base(new Query<MarketLocalization>(name))
        {
            Arguments = new MarketLocalizableResourceMarketLocalizationsArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder(IQuery<MarketLocalization> query) : base(query)
        {
            Arguments = new MarketLocalizableResourceMarketLocalizationsArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder SetArguments(Action<MarketLocalizableResourceMarketLocalizationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MarketLocalizableResourceMarketLocalizationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}