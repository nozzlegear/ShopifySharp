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
    public sealed class RefundDutyQueryBuilder : FieldsQueryBuilderBase<RefundDuty, RefundDutyQueryBuilder>
    {
        protected override RefundDutyQueryBuilder Self => this;

        public RefundDutyQueryBuilder() : this("refundDuty")
        {
        }

        public RefundDutyQueryBuilder(string name) : base(new Query<RefundDuty>(name))
        {
        }

        public RefundDutyQueryBuilder(IQuery<RefundDuty> query) : base(query)
        {
        }

        public RefundDutyQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public RefundDutyQueryBuilder OriginalDuty(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DutyQueryBuilder> build)
        {
            var query = new Query<Duty>("originalDuty");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Duty>(query);
            return this;
        }
    }
}