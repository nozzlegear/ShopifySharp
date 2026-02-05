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
    public sealed class PriceListFixedPricesAddPayloadQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesAddPayload, PriceListFixedPricesAddPayloadQueryBuilder>
    {
        protected override PriceListFixedPricesAddPayloadQueryBuilder Self => this;

        public PriceListFixedPricesAddPayloadQueryBuilder() : this("priceListFixedPricesAddPayload")
        {
        }

        public PriceListFixedPricesAddPayloadQueryBuilder(string name) : base(new Query<PriceListFixedPricesAddPayload>(name))
        {
        }

        public PriceListFixedPricesAddPayloadQueryBuilder(IQuery<PriceListFixedPricesAddPayload> query) : base(query)
        {
        }

        public PriceListFixedPricesAddPayloadQueryBuilder Prices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("prices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListFixedPricesAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}