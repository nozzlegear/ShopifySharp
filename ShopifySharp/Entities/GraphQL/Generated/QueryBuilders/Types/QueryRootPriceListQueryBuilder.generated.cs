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
    public sealed class QueryRootPriceListQueryBuilder : FieldsQueryBuilderBase<PriceList, QueryRootPriceListQueryBuilder>, IHasArguments<QueryRootPriceListArgumentsBuilder>
    {
        public QueryRootPriceListArgumentsBuilder Arguments { get; }
        protected override QueryRootPriceListQueryBuilder Self => this;

        public QueryRootPriceListQueryBuilder(string name) : base(new Query<PriceList>(name))
        {
            Arguments = new QueryRootPriceListArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPriceListQueryBuilder(IQuery<PriceList> query) : base(query)
        {
            Arguments = new QueryRootPriceListArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPriceListQueryBuilder SetArguments(Action<QueryRootPriceListArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPriceListQueryBuilder Catalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public QueryRootPriceListQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public QueryRootPriceListQueryBuilder FixedPricesCount()
        {
            base.InnerQuery.AddField("fixedPricesCount");
            return this;
        }

        public QueryRootPriceListQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootPriceListQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootPriceListQueryBuilder Parent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListParentQueryBuilder> build)
        {
            var query = new Query<PriceListParent>("parent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListParentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListParent>(query);
            return this;
        }

        public QueryRootPriceListQueryBuilder Prices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder> build)
        {
            var query = new Query<PriceListPriceConnection>("prices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceConnection>(query);
            return this;
        }

        public QueryRootPriceListQueryBuilder QuantityRules(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityRuleConnection>("quantityRules");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleConnection>(query);
            return this;
        }
    }
}