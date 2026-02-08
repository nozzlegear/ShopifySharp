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
    public sealed class DiscountBuyerSelectionAllQueryBuilder : FieldsQueryBuilderBase<DiscountBuyerSelectionAll, DiscountBuyerSelectionAllQueryBuilder>
    {
        protected override DiscountBuyerSelectionAllQueryBuilder Self => this;

        public DiscountBuyerSelectionAllQueryBuilder() : this("discountBuyerSelectionAll")
        {
        }

        public DiscountBuyerSelectionAllQueryBuilder(string name) : base(new Query<DiscountBuyerSelectionAll>(name))
        {
        }

        public DiscountBuyerSelectionAllQueryBuilder(IQuery<DiscountBuyerSelectionAll> query) : base(query)
        {
        }

        public DiscountBuyerSelectionAllQueryBuilder All()
        {
            base.InnerQuery.AddField("all");
            return this;
        }
    }
}