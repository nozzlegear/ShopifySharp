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
    public sealed class PriceListParentQueryBuilder : FieldsQueryBuilderBase<PriceListParent, PriceListParentQueryBuilder>
    {
        protected override PriceListParentQueryBuilder Self => this;

        public PriceListParentQueryBuilder() : this("priceListParent")
        {
        }

        public PriceListParentQueryBuilder(string name) : base(new Query<PriceListParent>(name))
        {
        }

        public PriceListParentQueryBuilder(IQuery<PriceListParent> query) : base(query)
        {
        }

        public PriceListParentQueryBuilder Adjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListAdjustmentQueryBuilder> build)
        {
            var query = new Query<PriceListAdjustment>("adjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListAdjustment>(query);
            return this;
        }

        public PriceListParentQueryBuilder Settings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListAdjustmentSettingsQueryBuilder> build)
        {
            var query = new Query<PriceListAdjustmentSettings>("settings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListAdjustmentSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListAdjustmentSettings>(query);
            return this;
        }
    }
}