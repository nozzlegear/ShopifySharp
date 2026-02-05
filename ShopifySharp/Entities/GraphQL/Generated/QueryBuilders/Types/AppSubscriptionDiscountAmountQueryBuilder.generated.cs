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
    public sealed class AppSubscriptionDiscountAmountQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionDiscountAmount, AppSubscriptionDiscountAmountQueryBuilder>
    {
        protected override AppSubscriptionDiscountAmountQueryBuilder Self => this;

        public AppSubscriptionDiscountAmountQueryBuilder() : this("appSubscriptionDiscountAmount")
        {
        }

        public AppSubscriptionDiscountAmountQueryBuilder(string name) : base(new Query<AppSubscriptionDiscountAmount>(name))
        {
        }

        public AppSubscriptionDiscountAmountQueryBuilder(IQuery<AppSubscriptionDiscountAmount> query) : base(query)
        {
        }

        public AppSubscriptionDiscountAmountQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}