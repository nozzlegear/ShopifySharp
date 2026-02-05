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
    public sealed class DiscountCombinesWithQueryBuilder : FieldsQueryBuilderBase<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>
    {
        protected override DiscountCombinesWithQueryBuilder Self => this;

        public DiscountCombinesWithQueryBuilder() : this("discountCombinesWith")
        {
        }

        public DiscountCombinesWithQueryBuilder(string name) : base(new Query<DiscountCombinesWith>(name))
        {
        }

        public DiscountCombinesWithQueryBuilder(IQuery<DiscountCombinesWith> query) : base(query)
        {
        }

        public DiscountCombinesWithQueryBuilder OrderDiscounts()
        {
            base.InnerQuery.AddField("orderDiscounts");
            return this;
        }

        public DiscountCombinesWithQueryBuilder ProductDiscounts()
        {
            base.InnerQuery.AddField("productDiscounts");
            return this;
        }

        public DiscountCombinesWithQueryBuilder ShippingDiscounts()
        {
            base.InnerQuery.AddField("shippingDiscounts");
            return this;
        }
    }
}