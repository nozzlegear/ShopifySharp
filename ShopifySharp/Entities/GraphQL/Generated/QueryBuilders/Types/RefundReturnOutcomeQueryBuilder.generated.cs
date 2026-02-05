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
    public sealed class RefundReturnOutcomeQueryBuilder : FieldsQueryBuilderBase<RefundReturnOutcome, RefundReturnOutcomeQueryBuilder>
    {
        protected override RefundReturnOutcomeQueryBuilder Self => this;

        public RefundReturnOutcomeQueryBuilder() : this("refundReturnOutcome")
        {
        }

        public RefundReturnOutcomeQueryBuilder(string name) : base(new Query<RefundReturnOutcome>(name))
        {
        }

        public RefundReturnOutcomeQueryBuilder(IQuery<RefundReturnOutcome> query) : base(query)
        {
        }

        public RefundReturnOutcomeQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public RefundReturnOutcomeQueryBuilder SuggestedRefundMethods(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder> build)
        {
            var query = new Query<ISuggestedRefundMethod>("suggestedRefundMethods");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISuggestedRefundMethod>(query);
            return this;
        }

        public RefundReturnOutcomeQueryBuilder SuggestedTransactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder> build)
        {
            var query = new Query<SuggestedOrderTransaction>("suggestedTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedOrderTransaction>(query);
            return this;
        }
    }
}