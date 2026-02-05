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
    public sealed class MarketWebPresenceQueryBuilder : FieldsQueryBuilderBase<MarketWebPresence, MarketWebPresenceQueryBuilder>
    {
        protected override MarketWebPresenceQueryBuilder Self => this;

        public MarketWebPresenceQueryBuilder() : this("marketWebPresence")
        {
        }

        public MarketWebPresenceQueryBuilder(string name) : base(new Query<MarketWebPresence>(name))
        {
        }

        public MarketWebPresenceQueryBuilder(IQuery<MarketWebPresence> query) : base(query)
        {
        }

        public MarketWebPresenceQueryBuilder AlternateLocales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("alternateLocales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder DefaultLocale(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("defaultLocale");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder Domain(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder> build)
        {
            var query = new Query<Domain>("domain");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Domain>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketWebPresenceQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder Markets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder> build)
        {
            var query = new Query<MarketConnection>("markets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConnection>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder RootUrls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceRootUrlQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceRootUrl>("rootUrls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceRootUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceRootUrl>(query);
            return this;
        }

        public MarketWebPresenceQueryBuilder SubfolderSuffix()
        {
            base.InnerQuery.AddField("subfolderSuffix");
            return this;
        }
    }
}