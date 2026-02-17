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
    public sealed class SuggestedRefundMethodQueryBuilder : FieldsQueryBuilderBase<ISuggestedRefundMethod, SuggestedRefundMethodQueryBuilder>
    {
        protected override SuggestedRefundMethodQueryBuilder Self => this;

        public SuggestedRefundMethodQueryBuilder() : this("suggestedRefundMethod")
        {
        }

        public SuggestedRefundMethodQueryBuilder(string name) : base(new Query<ISuggestedRefundMethod>(name))
        {
        }

        public SuggestedRefundMethodQueryBuilder(IQuery<ISuggestedRefundMethod> query) : base(query)
        {
        }

        public SuggestedRefundMethodQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedRefundMethodQueryBuilder MaximumRefundable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}