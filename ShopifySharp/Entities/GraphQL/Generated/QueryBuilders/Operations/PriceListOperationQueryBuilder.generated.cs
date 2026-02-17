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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class PriceListOperationQueryBuilder : FieldsQueryBuilderBase<PriceList, PriceListOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceList>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PriceListArgumentsBuilder Arguments { get; }
        protected override PriceListOperationQueryBuilder Self => this;

        public PriceListOperationQueryBuilder() : this("priceList")
        {
        }

        public PriceListOperationQueryBuilder(string name) : base(new Query<PriceList>(name))
        {
            Arguments = new PriceListArgumentsBuilder(base.InnerQuery);
        }

        public PriceListOperationQueryBuilder(IQuery<PriceList> query) : base(query)
        {
            Arguments = new PriceListArgumentsBuilder(base.InnerQuery);
        }

        public PriceListOperationQueryBuilder Catalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public PriceListOperationQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public PriceListOperationQueryBuilder FixedPricesCount()
        {
            base.InnerQuery.AddField("fixedPricesCount");
            return this;
        }

        public PriceListOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PriceListOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PriceListOperationQueryBuilder Parent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListParentQueryBuilder> build)
        {
            var query = new Query<PriceListParent>("parent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListParentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListParent>(query);
            return this;
        }

        public PriceListOperationQueryBuilder Prices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder> build)
        {
            var query = new Query<PriceListPriceConnection>("prices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceConnection>(query);
            return this;
        }

        public PriceListOperationQueryBuilder QuantityRules(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityRuleConnection>("quantityRules");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleConnection>(query);
            return this;
        }
    }
}