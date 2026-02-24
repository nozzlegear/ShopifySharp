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
    public sealed class QueryRootShopLocalesQueryBuilder : FieldsQueryBuilderBase<ShopLocale, QueryRootShopLocalesQueryBuilder>, IHasArguments<QueryRootShopLocalesArgumentsBuilder>
    {
        public QueryRootShopLocalesArgumentsBuilder Arguments { get; }
        protected override QueryRootShopLocalesQueryBuilder Self => this;

        public QueryRootShopLocalesQueryBuilder(string name) : base(new Query<ShopLocale>(name))
        {
            Arguments = new QueryRootShopLocalesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopLocalesQueryBuilder(IQuery<ShopLocale> query) : base(query)
        {
            Arguments = new QueryRootShopLocalesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopLocalesQueryBuilder SetArguments(Action<QueryRootShopLocalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopLocalesQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public QueryRootShopLocalesQueryBuilder MarketWebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public QueryRootShopLocalesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootShopLocalesQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public QueryRootShopLocalesQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }
    }
}