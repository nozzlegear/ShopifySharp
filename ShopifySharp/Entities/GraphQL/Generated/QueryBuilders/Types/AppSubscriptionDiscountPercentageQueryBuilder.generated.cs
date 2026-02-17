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
    public sealed class AppSubscriptionDiscountPercentageQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionDiscountPercentage, AppSubscriptionDiscountPercentageQueryBuilder>
    {
        protected override AppSubscriptionDiscountPercentageQueryBuilder Self => this;

        public AppSubscriptionDiscountPercentageQueryBuilder() : this("appSubscriptionDiscountPercentage")
        {
        }

        public AppSubscriptionDiscountPercentageQueryBuilder(string name) : base(new Query<AppSubscriptionDiscountPercentage>(name))
        {
        }

        public AppSubscriptionDiscountPercentageQueryBuilder(IQuery<AppSubscriptionDiscountPercentage> query) : base(query)
        {
        }

        public AppSubscriptionDiscountPercentageQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}