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
    public sealed class FulfillmentLineItemQueryBuilder : FieldsQueryBuilderBase<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>
    {
        protected override FulfillmentLineItemQueryBuilder Self => this;

        public FulfillmentLineItemQueryBuilder() : this("fulfillmentLineItem")
        {
        }

        public FulfillmentLineItemQueryBuilder(string name) : base(new Query<FulfillmentLineItem>(name))
        {
        }

        public FulfillmentLineItemQueryBuilder(IQuery<FulfillmentLineItem> query) : base(query)
        {
        }

        [Obsolete("Use `discountedTotalSet` instead.")]
        public FulfillmentLineItemQueryBuilder DiscountedTotal()
        {
            base.InnerQuery.AddField("discountedTotal");
            return this;
        }

        public FulfillmentLineItemQueryBuilder DiscountedTotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FulfillmentLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentLineItemQueryBuilder LineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        [Obsolete("Use `originalTotalSet` instead.")]
        public FulfillmentLineItemQueryBuilder OriginalTotal()
        {
            base.InnerQuery.AddField("originalTotal");
            return this;
        }

        public FulfillmentLineItemQueryBuilder OriginalTotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FulfillmentLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}