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