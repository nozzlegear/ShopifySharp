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