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
    public sealed class ShippingRateQueryBuilder : FieldsQueryBuilderBase<ShippingRate, ShippingRateQueryBuilder>
    {
        protected override ShippingRateQueryBuilder Self => this;

        public ShippingRateQueryBuilder() : this("shippingRate")
        {
        }

        public ShippingRateQueryBuilder(string name) : base(new Query<ShippingRate>(name))
        {
        }

        public ShippingRateQueryBuilder(IQuery<ShippingRate> query) : base(query)
        {
        }

        public ShippingRateQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ShippingRateQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShippingRateQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}