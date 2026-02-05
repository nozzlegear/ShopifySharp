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
    public sealed class DiscountQuantityQueryBuilder : FieldsQueryBuilderBase<DiscountQuantity, DiscountQuantityQueryBuilder>
    {
        protected override DiscountQuantityQueryBuilder Self => this;

        public DiscountQuantityQueryBuilder() : this("discountQuantity")
        {
        }

        public DiscountQuantityQueryBuilder(string name) : base(new Query<DiscountQuantity>(name))
        {
        }

        public DiscountQuantityQueryBuilder(IQuery<DiscountQuantity> query) : base(query)
        {
        }

        public DiscountQuantityQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}