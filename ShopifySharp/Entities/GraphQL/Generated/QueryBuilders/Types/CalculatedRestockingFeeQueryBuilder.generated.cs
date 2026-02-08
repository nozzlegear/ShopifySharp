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
    public sealed class CalculatedRestockingFeeQueryBuilder : FieldsQueryBuilderBase<CalculatedRestockingFee, CalculatedRestockingFeeQueryBuilder>
    {
        protected override CalculatedRestockingFeeQueryBuilder Self => this;

        public CalculatedRestockingFeeQueryBuilder() : this("calculatedRestockingFee")
        {
        }

        public CalculatedRestockingFeeQueryBuilder(string name) : base(new Query<CalculatedRestockingFee>(name))
        {
        }

        public CalculatedRestockingFeeQueryBuilder(IQuery<CalculatedRestockingFee> query) : base(query)
        {
        }

        public CalculatedRestockingFeeQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedRestockingFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedRestockingFeeQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}