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
    public sealed class PriceListQueryBuilder : FieldsQueryBuilderBase<PriceList, PriceListQueryBuilder>
    {
        protected override PriceListQueryBuilder Self => this;

        public PriceListQueryBuilder() : this("priceList")
        {
        }

        public PriceListQueryBuilder(string name) : base(new Query<PriceList>(name))
        {
        }

        public PriceListQueryBuilder(IQuery<PriceList> query) : base(query)
        {
        }

        public PriceListQueryBuilder Catalog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public PriceListQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public PriceListQueryBuilder FixedPricesCount()
        {
            base.InnerQuery.AddField("fixedPricesCount");
            return this;
        }

        public PriceListQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PriceListQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PriceListQueryBuilder Parent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListParentQueryBuilder> build)
        {
            var query = new Query<PriceListParent>("parent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListParentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListParent>(query);
            return this;
        }

        public PriceListQueryBuilder Prices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder> build)
        {
            var query = new Query<PriceListPriceConnection>("prices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceConnection>(query);
            return this;
        }

        public PriceListQueryBuilder QuantityRules(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityRuleConnection>("quantityRules");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleConnection>(query);
            return this;
        }
    }
}