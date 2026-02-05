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
    public sealed class PriceListAdjustmentQueryBuilder : FieldsQueryBuilderBase<PriceListAdjustment, PriceListAdjustmentQueryBuilder>
    {
        protected override PriceListAdjustmentQueryBuilder Self => this;

        public PriceListAdjustmentQueryBuilder() : this("priceListAdjustment")
        {
        }

        public PriceListAdjustmentQueryBuilder(string name) : base(new Query<PriceListAdjustment>(name))
        {
        }

        public PriceListAdjustmentQueryBuilder(IQuery<PriceListAdjustment> query) : base(query)
        {
        }

        public PriceListAdjustmentQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public PriceListAdjustmentQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}