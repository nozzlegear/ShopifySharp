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
    public sealed class AllDiscountItemsQueryBuilder : FieldsQueryBuilderBase<AllDiscountItems, AllDiscountItemsQueryBuilder>
    {
        protected override AllDiscountItemsQueryBuilder Self => this;

        public AllDiscountItemsQueryBuilder() : this("allDiscountItems")
        {
        }

        public AllDiscountItemsQueryBuilder(string name) : base(new Query<AllDiscountItems>(name))
        {
        }

        public AllDiscountItemsQueryBuilder(IQuery<AllDiscountItems> query) : base(query)
        {
        }

        public AllDiscountItemsQueryBuilder AllItems()
        {
            base.InnerQuery.AddField("allItems");
            return this;
        }
    }
}