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
    public sealed class ReturnShippingFeeQueryBuilder : FieldsQueryBuilderBase<ReturnShippingFee, ReturnShippingFeeQueryBuilder>
    {
        protected override ReturnShippingFeeQueryBuilder Self => this;

        public ReturnShippingFeeQueryBuilder() : this("returnShippingFee")
        {
        }

        public ReturnShippingFeeQueryBuilder(string name) : base(new Query<ReturnShippingFee>(name))
        {
        }

        public ReturnShippingFeeQueryBuilder(IQuery<ReturnShippingFee> query) : base(query)
        {
        }

        public ReturnShippingFeeQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnShippingFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}