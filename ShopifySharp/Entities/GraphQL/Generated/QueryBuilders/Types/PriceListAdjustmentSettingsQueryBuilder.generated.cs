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
    public sealed class PriceListAdjustmentSettingsQueryBuilder : FieldsQueryBuilderBase<PriceListAdjustmentSettings, PriceListAdjustmentSettingsQueryBuilder>
    {
        protected override PriceListAdjustmentSettingsQueryBuilder Self => this;

        public PriceListAdjustmentSettingsQueryBuilder() : this("priceListAdjustmentSettings")
        {
        }

        public PriceListAdjustmentSettingsQueryBuilder(string name) : base(new Query<PriceListAdjustmentSettings>(name))
        {
        }

        public PriceListAdjustmentSettingsQueryBuilder(IQuery<PriceListAdjustmentSettings> query) : base(query)
        {
        }

        public PriceListAdjustmentSettingsQueryBuilder CompareAtMode()
        {
            base.InnerQuery.AddField("compareAtMode");
            return this;
        }
    }
}