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
    public sealed class AppSubscriptionDiscountValueQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionDiscountValue, AppSubscriptionDiscountValueQueryBuilder>
    {
        protected override AppSubscriptionDiscountValueQueryBuilder Self => this;

        public AppSubscriptionDiscountValueQueryBuilder() : this("appSubscriptionDiscountValue")
        {
        }

        public AppSubscriptionDiscountValueQueryBuilder(string name) : base(new Query<AppSubscriptionDiscountValue>(name))
        {
        }

        public AppSubscriptionDiscountValueQueryBuilder(IQuery<AppSubscriptionDiscountValue> query) : base(query)
        {
        }

        public AppSubscriptionDiscountValueQueryBuilder AppSubscriptionDiscountValue(Action<AppSubscriptionDiscountValueUnionCasesBuilder> build)
        {
            var query = new Query<AppSubscriptionDiscountValue>("appSubscriptionDiscountValue");
            var unionBuilder = new AppSubscriptionDiscountValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}