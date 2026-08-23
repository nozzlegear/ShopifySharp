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
    public sealed class RestockingFeeQueryBuilder : FieldsQueryBuilderBase<RestockingFee, RestockingFeeQueryBuilder>
    {
        protected override RestockingFeeQueryBuilder Self => this;

        public RestockingFeeQueryBuilder() : this("restockingFee")
        {
        }

        public RestockingFeeQueryBuilder(string name) : base(new Query<RestockingFee>(name))
        {
        }

        public RestockingFeeQueryBuilder(IQuery<RestockingFee> query) : base(query)
        {
        }

        public RestockingFeeQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public RestockingFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public RestockingFeeQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}