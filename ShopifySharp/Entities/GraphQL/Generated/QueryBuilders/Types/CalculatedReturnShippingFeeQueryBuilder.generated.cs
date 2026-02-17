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
    public sealed class CalculatedReturnShippingFeeQueryBuilder : FieldsQueryBuilderBase<CalculatedReturnShippingFee, CalculatedReturnShippingFeeQueryBuilder>
    {
        protected override CalculatedReturnShippingFeeQueryBuilder Self => this;

        public CalculatedReturnShippingFeeQueryBuilder() : this("calculatedReturnShippingFee")
        {
        }

        public CalculatedReturnShippingFeeQueryBuilder(string name) : base(new Query<CalculatedReturnShippingFee>(name))
        {
        }

        public CalculatedReturnShippingFeeQueryBuilder(IQuery<CalculatedReturnShippingFee> query) : base(query)
        {
        }

        public CalculatedReturnShippingFeeQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedReturnShippingFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}