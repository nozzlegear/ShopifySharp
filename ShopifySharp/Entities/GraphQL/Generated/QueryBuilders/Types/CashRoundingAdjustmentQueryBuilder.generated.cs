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
    public sealed class CashRoundingAdjustmentQueryBuilder : FieldsQueryBuilderBase<CashRoundingAdjustment, CashRoundingAdjustmentQueryBuilder>
    {
        protected override CashRoundingAdjustmentQueryBuilder Self => this;

        public CashRoundingAdjustmentQueryBuilder() : this("cashRoundingAdjustment")
        {
        }

        public CashRoundingAdjustmentQueryBuilder(string name) : base(new Query<CashRoundingAdjustment>(name))
        {
        }

        public CashRoundingAdjustmentQueryBuilder(IQuery<CashRoundingAdjustment> query) : base(query)
        {
        }

        public CashRoundingAdjustmentQueryBuilder PaymentSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("paymentSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CashRoundingAdjustmentQueryBuilder RefundSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("refundSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}