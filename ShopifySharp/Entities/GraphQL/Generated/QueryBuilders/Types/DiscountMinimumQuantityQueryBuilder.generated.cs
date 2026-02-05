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
    public sealed class DiscountMinimumQuantityQueryBuilder : FieldsQueryBuilderBase<DiscountMinimumQuantity, DiscountMinimumQuantityQueryBuilder>
    {
        protected override DiscountMinimumQuantityQueryBuilder Self => this;

        public DiscountMinimumQuantityQueryBuilder() : this("discountMinimumQuantity")
        {
        }

        public DiscountMinimumQuantityQueryBuilder(string name) : base(new Query<DiscountMinimumQuantity>(name))
        {
        }

        public DiscountMinimumQuantityQueryBuilder(IQuery<DiscountMinimumQuantity> query) : base(query)
        {
        }

        public DiscountMinimumQuantityQueryBuilder GreaterThanOrEqualToQuantity()
        {
            base.InnerQuery.AddField("greaterThanOrEqualToQuantity");
            return this;
        }
    }
}