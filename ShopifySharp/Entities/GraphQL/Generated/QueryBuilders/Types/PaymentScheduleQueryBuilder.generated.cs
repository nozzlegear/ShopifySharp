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
    public sealed class PaymentScheduleQueryBuilder : FieldsQueryBuilderBase<PaymentSchedule, PaymentScheduleQueryBuilder>
    {
        protected override PaymentScheduleQueryBuilder Self => this;

        public PaymentScheduleQueryBuilder() : this("paymentSchedule")
        {
        }

        public PaymentScheduleQueryBuilder(string name) : base(new Query<PaymentSchedule>(name))
        {
        }

        public PaymentScheduleQueryBuilder(IQuery<PaymentSchedule> query) : base(query)
        {
        }

        public PaymentScheduleQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PaymentScheduleQueryBuilder BalanceDue(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balanceDue");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PaymentScheduleQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public PaymentScheduleQueryBuilder Due()
        {
            base.InnerQuery.AddField("due");
            return this;
        }

        public PaymentScheduleQueryBuilder DueAt()
        {
            base.InnerQuery.AddField("dueAt");
            return this;
        }

        public PaymentScheduleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentScheduleQueryBuilder IssuedAt()
        {
            base.InnerQuery.AddField("issuedAt");
            return this;
        }

        public PaymentScheduleQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentScheduleQueryBuilder TotalBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}