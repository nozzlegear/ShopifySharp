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
    public sealed class ExchangeV2AdditionsQueryBuilder : FieldsQueryBuilderBase<ExchangeV2Additions, ExchangeV2AdditionsQueryBuilder>
    {
        protected override ExchangeV2AdditionsQueryBuilder Self => this;

        public ExchangeV2AdditionsQueryBuilder() : this("exchangeV2Additions")
        {
        }

        public ExchangeV2AdditionsQueryBuilder(string name) : base(new Query<ExchangeV2Additions>(name))
        {
        }

        public ExchangeV2AdditionsQueryBuilder(IQuery<ExchangeV2Additions> query) : base(query)
        {
        }

        public ExchangeV2AdditionsQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2LineItemQueryBuilder> build)
        {
            var query = new Query<ExchangeV2LineItem>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2LineItem>(query);
            return this;
        }

        public ExchangeV2AdditionsQueryBuilder SubtotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ExchangeV2AdditionsQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public ExchangeV2AdditionsQueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}