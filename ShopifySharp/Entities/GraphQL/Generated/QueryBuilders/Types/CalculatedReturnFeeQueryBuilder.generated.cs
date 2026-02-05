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
    public sealed class CalculatedReturnFeeQueryBuilder : FieldsQueryBuilderBase<ICalculatedReturnFee, CalculatedReturnFeeQueryBuilder>
    {
        protected override CalculatedReturnFeeQueryBuilder Self => this;

        public CalculatedReturnFeeQueryBuilder() : this("calculatedReturnFee")
        {
        }

        public CalculatedReturnFeeQueryBuilder(string name) : base(new Query<ICalculatedReturnFee>(name))
        {
        }

        public CalculatedReturnFeeQueryBuilder(IQuery<ICalculatedReturnFee> query) : base(query)
        {
        }

        public CalculatedReturnFeeQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedReturnFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}