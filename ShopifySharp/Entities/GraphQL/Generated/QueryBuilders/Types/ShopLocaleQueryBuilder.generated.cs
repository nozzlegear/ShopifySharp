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
    public sealed class ShopLocaleQueryBuilder : FieldsQueryBuilderBase<ShopLocale, ShopLocaleQueryBuilder>
    {
        protected override ShopLocaleQueryBuilder Self => this;

        public ShopLocaleQueryBuilder() : this("shopLocale")
        {
        }

        public ShopLocaleQueryBuilder(string name) : base(new Query<ShopLocale>(name))
        {
        }

        public ShopLocaleQueryBuilder(IQuery<ShopLocale> query) : base(query)
        {
        }

        public ShopLocaleQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopLocaleQueryBuilder MarketWebPresences(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresences");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public ShopLocaleQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopLocaleQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public ShopLocaleQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }
    }
}