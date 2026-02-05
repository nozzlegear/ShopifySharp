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
    public sealed class AppSubscriptionDiscountValueUnionCasesBuilder : UnionCasesBuilderBase<AppSubscriptionDiscountValue, AppSubscriptionDiscountValueUnionCasesBuilder>
    {
        protected override AppSubscriptionDiscountValueUnionCasesBuilder Self => this;

        public AppSubscriptionDiscountValueUnionCasesBuilder(string fieldName = "appSubscriptionDiscountValue") : this(new Query<AppSubscriptionDiscountValue>(fieldName))
        {
        }

        public AppSubscriptionDiscountValueUnionCasesBuilder(IQuery<AppSubscriptionDiscountValue> query) : base(query)
        {
        }

        public AppSubscriptionDiscountValueUnionCasesBuilder OnAppSubscriptionDiscountAmount(Action<AppSubscriptionDiscountAmountQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionDiscountAmount>("... on AppSubscriptionDiscountAmount");
            var queryBuilder = new AppSubscriptionDiscountAmountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public AppSubscriptionDiscountValueUnionCasesBuilder OnAppSubscriptionDiscountPercentage(Action<AppSubscriptionDiscountPercentageQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionDiscountPercentage>("... on AppSubscriptionDiscountPercentage");
            var queryBuilder = new AppSubscriptionDiscountPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}