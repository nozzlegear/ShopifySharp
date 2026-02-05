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
    public sealed class MarketCatalogQueryBuilder : FieldsQueryBuilderBase<MarketCatalog, MarketCatalogQueryBuilder>
    {
        protected override MarketCatalogQueryBuilder Self => this;

        public MarketCatalogQueryBuilder() : this("marketCatalog")
        {
        }

        public MarketCatalogQueryBuilder(string name) : base(new Query<MarketCatalog>(name))
        {
        }

        public MarketCatalogQueryBuilder(IQuery<MarketCatalog> query) : base(query)
        {
        }

        public MarketCatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketCatalogQueryBuilder Markets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder> build)
        {
            var query = new Query<MarketConnection>("markets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConnection>(query);
            return this;
        }

        public MarketCatalogQueryBuilder MarketsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("marketsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public MarketCatalogQueryBuilder Operations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder> build)
        {
            var query = new Query<IResourceOperation>("operations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IResourceOperation>(query);
            return this;
        }

        public MarketCatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public MarketCatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public MarketCatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MarketCatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}