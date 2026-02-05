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
    public sealed class SuggestedStoreCreditRefundQueryBuilder : FieldsQueryBuilderBase<SuggestedStoreCreditRefund, SuggestedStoreCreditRefundQueryBuilder>
    {
        protected override SuggestedStoreCreditRefundQueryBuilder Self => this;

        public SuggestedStoreCreditRefundQueryBuilder() : this("suggestedStoreCreditRefund")
        {
        }

        public SuggestedStoreCreditRefundQueryBuilder(string name) : base(new Query<SuggestedStoreCreditRefund>(name))
        {
        }

        public SuggestedStoreCreditRefundQueryBuilder(IQuery<SuggestedStoreCreditRefund> query) : base(query)
        {
        }

        public SuggestedStoreCreditRefundQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedStoreCreditRefundQueryBuilder ExpiresAt()
        {
            base.InnerQuery.AddField("expiresAt");
            return this;
        }

        public SuggestedStoreCreditRefundQueryBuilder MaximumRefundable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}